﻿using System.Collections.Generic;
using System.Linq;
using System;
using Fclp;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Globalization;
using System.Collections;

namespace SysCommand
{
    public class ArgumentsParser
    {
        /// <summary>
        /// Map: a, b, c, d, e, f = 1
        /// Input: 1 -b -c -d - j
        /// Result expected:
        ///  1: Position
        /// -b: Name
        /// -c: Name
        /// -d: Name
        /// -e: HasNoInput
        /// -j: NotMapped
        /// -f: DefaultValue
        /// </summary>
        public enum ArgumentMappingType
        {
            Name,
            Position,
            DefaultValue,
            HasNoInput,
            NotMapped,
        }

        public class ArgumentMap
        {
            public string Key { get; private set; }
            public Type Type { get; private set; }
            public object DefaultValue { get; private set; }
            public bool IsOptional { get; private set; }

            public ArgumentMap(string key, Type type, bool isOptional, object defaultValue)
            {
                this.Key = key;
                this.Type = type;
                this.IsOptional = isOptional;
                this.DefaultValue = defaultValue;
            }

            public override string ToString()
            {
                return "[" + this.Key + ", " + this.Type + "]";
            }

        }

        public class ArgumentSimple
        {
            public string Key { get; set; }
            public string Value { get; set; }

            public ArgumentSimple(string key, string value)
            {
                this.Key = key;
                this.Value = value;
            }

            public override string ToString()
            {
                return "[" + this.Key + ", " + this.Value + "]";
            }
        }

        public class ArgumentMapped
        {
            public string Key { get; set; }
            public object ValueRaw { get; set; }
            public object Value { get; set; }
            public bool HasUnsuporttedType { get; set; }
            public bool HasInvalidInput { get; set; }
            public Type Type { get; set; }
            public ArgumentMappingType MappingType { get; set; }

            public bool IsMapped
            {
                get
                {
                    if (this.MappingType.In(ArgumentMappingType.Name, ArgumentMappingType.Position))
                        return true;
                    return false;
                }
            }

            public bool IsMappedOrHasDefaultValue
            {
                get
                {
                    if (this.IsMapped || this.MappingType == ArgumentMappingType.DefaultValue)
                        return true;
                    return false;
                }
            }

            public ArgumentMapped(string key, string valueRaw, string value, Type type)
            {
                this.Key = key;
                this.Value = value;
                this.ValueRaw = valueRaw;
                this.Type = type;
            }

            public override string ToString()
            {
                return "[" + this.Key + ", " + this.Value + "]";
            }

        }

        public IEnumerable<ArgumentMapped> Parser(string[] args, bool enablePositionedArgs = true, params ArgumentMap[] maps)
        {
            var argumentsMappeds = new List<ArgumentMapped>();
            var argumentsSimples = this.Parser(args).ToList();
            var mapsUseds = maps.ToList();

            var i = 0;
            using (IEnumerator<ArgumentSimple> enumerator = argumentsSimples.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var argSimple = enumerator.Current;
                    var map = mapsUseds.FirstOrDefault(f => f.Key == argSimple.Key);

                    if (enablePositionedArgs && map == null && argSimple.Key == null)
                        map = mapsUseds.FirstOrDefault();
                    
                    if (map != null)
                    {
                        var argMapped = new ArgumentMapped(map.Key, this.GetValueRaw(argSimple.Value), null, map.Type);

                        if (argSimple.Key == null)
                        {
                            argMapped.MappingType = ArgumentMappingType.Position;
                        }
                        else
                        {
                            argMapped.MappingType = ArgumentMappingType.Name;
                        }

                        argumentsMappeds.Add(argMapped);
                        this.ParseArgument(enumerator, argumentsSimples, ref i, argSimple, map, argMapped);

                        mapsUseds.Remove(map);
                    }
                    else
                    {
                        var argMapped = new ArgumentMapped(argSimple.Key, this.GetValueRaw(argSimple.Value), argSimple.Value, typeof(string));
                        argMapped.MappingType = ArgumentMappingType.NotMapped;
                        argumentsMappeds.Add(argMapped);
                    }

                    i++;
                }
            }

            foreach (var map in maps)
            {
                var exists = argumentsMappeds.Exists(f => f.Key == map.Key);
                if (!exists)
                {
                    var argMapped = new ArgumentMapped(map.Key, null, null, map.Type);
                    argumentsMappeds.Add(argMapped);

                    if (map.IsOptional)
                    {
                        argMapped.MappingType = ArgumentMappingType.DefaultValue;
                        argMapped.Value = map.DefaultValue;
                        argMapped.ValueRaw = map.DefaultValue;
                    }
                    else
                    {
                        argMapped.MappingType = ArgumentMappingType.HasNoInput;
                    }
                }
            }

            //string.Format("The type '{0}' not supported", map.Type.ToString());
            //var msgInputInvalid = "The input value is invalid.";

            return argumentsMappeds;
        }

        private void ParseArgument(IEnumerator<ArgumentSimple> enumerator, List<ArgumentSimple> argumentsSimples, ref int i, ArgumentSimple argSimple, ArgumentMap map, ArgumentMapped argMapped)
        {
            if (argSimple.Value == null && map.Type != typeof(bool))
            {
                argMapped.Value = GetDefaultForType(map.Type);
            }
            else
            {
                var value = argSimple.Value;
                var hasInvalidInput = false;
                var hasUnsuporttedType = false;
                object valueConverted = null;
                var iDelegate = i;
                Action<int> actionConvertSuccess = (int position) =>
                {
                    if (position > 0)
                    {
                        enumerator.MoveNext();
                        iDelegate++;
                    }
                };

                if (IsEnum(map.Type))
                {
                    var values = new List<string>() { argSimple.Value };
                    values.AddRange(this.GetArgumentSimplesOrphans(argumentsSimples, i + 1));
                    var valueArray = values.ToArray();
                    argMapped.ValueRaw = this.GetValueRaw(valueArray);
                    valueConverted = this.TryConvertEnum(map.Type, valueArray, out hasInvalidInput, actionConvertSuccess);
                    i = iDelegate;
                }
                else if (map.Type != typeof(string) && typeof(IEnumerable).IsAssignableFrom(map.Type))
                {
                    var values = new List<string>() { argSimple.Value };
                    values.AddRange(this.GetArgumentSimplesOrphans(argumentsSimples, i + 1));
                    var valueArray = values.ToArray();
                    argMapped.ValueRaw = this.GetValueRaw(valueArray);

                    valueConverted = this.TryConvertCollection(map.Type, valueArray, out hasInvalidInput, out hasUnsuporttedType, actionConvertSuccess);
                    i = iDelegate;
                }
                else
                {
                    valueConverted = this.TryConvertPrimitives(map.Type, value, out hasInvalidInput, out hasUnsuporttedType);
                }

                argMapped.HasInvalidInput = hasInvalidInput;
                argMapped.HasUnsuporttedType = hasUnsuporttedType;

                if (!hasInvalidInput && !hasUnsuporttedType)
                    argMapped.Value = valueConverted;
            }
        }

        private IEnumerable<string> GetArgumentSimplesOrphans(List<ArgumentSimple> arguments, int iStart)
        {
            // get nexts orphans values
            for (var iArgSimple = iStart; arguments.Count > iArgSimple; iArgSimple++)
                if (arguments[iArgSimple].Key == null)
                    yield return arguments[iArgSimple].Value;
                else
                    break;
        }

        private object TryConvertEnum(Type type, string[] values, out bool hasInvalidInput, Action<int> successConvertCallback = null)
        {
            Type typeOriginal = this.GetTypeOrTypeOfNullable(type);
            int valueConverted = 0;
            var enumNames = Enum.GetNames(typeOriginal);
            var enumValues = Enum.GetValues(typeOriginal).Cast<int>().Select(f => f.ToString()).ToList();
            var hasFlags = typeOriginal.IsDefined(typeof(FlagsAttribute), false);
            hasInvalidInput = false;

            // get next enum value
            // --enum1 value1 value2 --enum2 value1
            // [current.....] [next] [next+1......]
            // [current]: Has key "enum1"
            // [next]: Hasn't key, then is possible value
            // [next+1]: Has key, is not possible value
            for (var i = 0; values.Length > i; i++)
            {
                string enumValue = values[i];
                var currentIsIntegerValue = false;
                var currentIsNamedValue = enumNames.Any(f => f.ToLower() == enumValue.ToLower());

                // try in value
                if (!currentIsNamedValue)
                {
                    // if is char, try convert to int because can be a enum of char
                    if (enumValue.Length == 1 && !char.IsDigit(enumValue[0]))
                        enumValue = ((int)enumValue[0]).ToString();

                    currentIsIntegerValue = enumValues.Any(f => f == enumValue);
                }

                if (currentIsNamedValue || currentIsIntegerValue)
                {
                    // (1 + 2) + (1 + 2) = 6
                    // (1 | 2) | (1 | 2) = 3
                    var valueParsed = (int)Enum.Parse(typeOriginal, enumValue, true);
                    if (valueConverted == 0)
                        valueConverted = valueParsed;
                    else
                        valueConverted |= valueParsed;

                    if (successConvertCallback != null)
                        successConvertCallback(i);

                    if (!hasFlags)
                        break;
                }
                else 
                {
                    // only is invalid when the first value is invalid.
                    if (i == 0)
                       hasInvalidInput = true;
                    break;
                }
            }

            if (!hasInvalidInput)
                return Enum.Parse(typeOriginal, valueConverted.ToString());

            return valueConverted;
        }

        private object TryConvertCollection(Type type, string[] values, out bool hasInvalidInput, out bool hasUnsuporttedType, Action<int> successConvertCallback = null)
        {
            object list = null;
            var hasInvalidInputAux = false;
            var hasUnsuporttedTypeAux = false;
            hasInvalidInput = false;
            hasUnsuporttedType = false;

            var isList = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>) && type.GetGenericArguments().Length == 1;
            var isArray = type.IsArray && type.GetElementType() != null;
            if (isList || isArray)
            {
                Type typeList;
                if (isArray)
                    typeList = type.GetElementType();
                else
                    typeList = type.GetGenericArguments().FirstOrDefault();

                var iListRef = typeof(List<>);
                Type[] IListParam = { typeList };
                list = Activator.CreateInstance(iListRef.MakeGenericType(IListParam));

                for (var i = 0; values.Length > i; i++)
                {
                    var value = values[i];
                    var convertedValue = this.TryConvertPrimitives(typeList, value, out hasInvalidInputAux, out hasUnsuporttedTypeAux);
                    if (!hasInvalidInputAux && !hasUnsuporttedTypeAux)
                    {
                        list.GetType().GetMethod("Add").Invoke(list, new[] { convertedValue });
                        if (successConvertCallback != null)
                            successConvertCallback(i);
                    }
                    else
                    {
                        // only is invalid when the first value is invalid.
                        if (i == 0)
                        {
                            hasInvalidInput = hasInvalidInputAux;
                            hasUnsuporttedType = hasUnsuporttedTypeAux;
                            list = null;
                        }

                        break;
                    }
                }

                if (list != null && isArray)
                    list = list.GetType().GetMethod("ToArray").Invoke(list, null);
            }
            else
            {
                hasUnsuporttedType = true;
            }

            return list;
        }

        private object TryConvertPrimitives(Type type, string value, out bool hasInvalidInput, out bool hasUnsuporttedType)
        {
            object valueConverted = null;
            hasInvalidInput = false;
            hasUnsuporttedType = false;
            Type typeOriginal = this.GetTypeOrTypeOfNullable(type);

            if (value == null && typeOriginal != typeof(bool))
            {
                valueConverted = GetDefaultForType(type);
            }
            else
            {
                if (typeOriginal == typeof(decimal))
                {
                    decimal valueType;
                    if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(int))
                {
                    int valueType;
                    if (int.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(double))
                {
                    double valueType;
                    if (double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(DateTime))
                {
                    DateTime valueType;
                    if (DateTime.TryParse(value, CultureInfo.CurrentCulture, DateTimeStyles.None, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(bool))
                {
                    bool valueType;
                    if (string.IsNullOrWhiteSpace(value))
                        valueConverted = true;
                    else if (value == "0" || value == "-")
                        valueConverted = false;
                    else if (value == "1" || value == "+")
                        valueConverted = true;
                    else if (bool.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(byte))
                {
                    byte valueType;
                    if (byte.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(short))
                {
                    short valueType;
                    if (short.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(ushort))
                {
                    ushort valueType;
                    if (ushort.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(long))
                {
                    long valueType;
                    if (long.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(ulong))
                {
                    ulong valueType;
                    if (ulong.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(float))
                {
                    float valueType;
                    if (float.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(char))
                {
                    char valueType;
                    if (char.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(uint))
                {
                    uint valueType;
                    if (uint.TryParse(value, out valueType))
                        valueConverted = valueType;
                    else
                        hasInvalidInput = true;
                }
                else if (typeOriginal == typeof(string))
                {
                    valueConverted = value;
                }
                else
                {
                    hasUnsuporttedType = true;
                }
            }

            return valueConverted;
        }

        public IEnumerable<ArgumentSimple> Parser(string[] args)
        {
            var argsItems = new List<ArgumentSimple>();
            var trueChar = '+';
            var falseChar = '-';
            var enumerator = args.GetEnumerator();
            string value;

            var i = 0;
            while (enumerator.MoveNext())
            {
                // if is non parameter: [value] [123] [true] [\--scape-parameter]
                var arg = (string)enumerator.Current;
                if (!IsArgumentFormat(arg))
                {
                    argsItems.Add(new ArgumentSimple(null, GetValueScaped(arg)));
                    i++;
                    continue;
                }

                // -x=true     -> posLeft = "-x"; posRight = "true"
                // -x          -> posLeft = "-x"; posRight = null
                // --x:true    -> posLeft = "-x"; posRight = "true"
                // --x:=true   -> posLeft = "-x"; posRight = "=true"
                // --x=:true   -> posLeft = "-x"; posRight = ":true"
                
                var split = arg.Split(new char[] { '=', ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
                var posLeft = split.Length > 0 ? split[0] : null;
                var posRight = split.Length > 1 ? split[1] : null;

                var char0 = (posLeft.Length > 0) ? posLeft[0] : default(char);
                var char1 = (posLeft.Length > 1) ? posLeft[1] : default(char);            
                var lastLeftChar = posLeft.Last();

                // check if exists "+" or "-": [-x+] or [-x-]
                if (lastLeftChar.In(trueChar, falseChar))
                {
                    posLeft = posLeft.Remove(posLeft.Length - 1);
                    value = lastLeftChar == trueChar ? "true" : "false";
                }
                else if (posRight == null)
                {
                    // get next arg
                    value = args.Length > (i + 1) ? args[i + 1] : null;

                    // ignore if next arg is parameter: [-xyz --next-parameter ...]
                    if (IsArgumentFormat(value))
                    {
                        value = null;
                    }
                    // jump the next arg if is value: [-xyz value]
                    else
                    {
                        enumerator.MoveNext();
                        i++;
                    }
                }
                else
                {
                    value = posRight;
                }

                value = GetValueScaped(value);

                //if (string.IsNullOrWhiteSpace(value))
                //    value = "true";

                // -x -> single parameter
                if (char0 == '-' && char1 != '-')
                {
                    // remove "-": -xyz -> xyz
                    var keys = posLeft.Substring(1);
                    foreach (var key in keys)
                        argsItems.Add(new ArgumentSimple(key.ToString(), value));
                }
                else
                {
                    string key = posLeft;

                    // remove "--": --xyz -> xyz
                    if (char0 == '-' && char1 == '-')
                        key = key.Substring(1).Substring(1);
                    // remove "/": /xyz -> xyz
                    else
                        key = arg.Substring(1);

                    argsItems.Add(new ArgumentSimple(key, value));
                }

                i++;
            }

            return argsItems;
        }

        public static IEnumerable<ArgumentMap> GetArgumentMaps(MethodInfo method)
        {
            var parameters = method.GetParameters();
            foreach (var parameter in parameters)
                yield return GetArgumentMap(parameter);
        }

        public static ArgumentMap GetArgumentMap(ParameterInfo parameter)
        {
            var name = parameter.Name;
            var attribute = Attribute.GetCustomAttribute(parameter, typeof(ArgumentAttribute)) as ArgumentAttribute;

            if (attribute != null)
                name = parameter.Name;

            return new ArgumentMap(name, parameter.ParameterType, parameter.IsOptional, parameter.DefaultValue);
        }

        public static bool IsArgumentFormat(string value)
        {
            if (value == null || value.In("-", "--", "/"))
                return false;

            var isChar1Digit = (value.Length > 1) ? char.IsDigit(value[1]) : false;

            return value[0].In('-', '/') && !isChar1Digit;
        }

        public static string GetValueScaped(string value)
        {
            // "-"       = "-"
            // "/"       = "/"
            if (string.IsNullOrWhiteSpace(value) || value.Length <= 1)
                return value;

            var char0 = value[0];
            var char1 = value[1];
            var char3 = value.Length > 2 ? value[2] : default(char);

            // "\-"      = "-"
            // "\-test"  = "-test"
            var existsScape = char0 == '\\' && char1.In('-', '/');

            // "\\-"     = "\-"
            // "\\-test" = "\-test"
            var existsScapeAndBackslashInValue = char0 == '\\' && char1 == '\\' && char3.In('-', '/');

            if (existsScape || existsScapeAndBackslashInValue)
                value = value.Substring(1);

            return value;
        }

        public static object GetDefaultForType(Type targetType)
        {
            return targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
        }

        private string GetValueRaw(params string[] values)
        {
            if (values.Length == 1)
                return values[0];

            var hasString = false;
            var strBuilder = new StringBuilder();
            foreach (var value in values)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    hasString = true;
                    if (strBuilder.Length > 0)
                        strBuilder.Append(" ");

                    if (value.Contains(" "))
                    {
                        strBuilder.Append("\"");
                        strBuilder.Append(value);
                        strBuilder.Append("\"");
                    }
                    else
                    {
                        strBuilder.Append(value);
                    }
                }
            }

            return hasString ? strBuilder.ToString() : null;
        }

        private bool IsEnum(Type type)
        {   
            return this.GetTypeOrTypeOfNullable(type).IsEnum;
        }

        private Type GetTypeOrTypeOfNullable(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                return type.GetGenericArguments()[0];
            return type;
        }
    }
}