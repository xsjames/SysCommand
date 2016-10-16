﻿using SysCommand.Parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SysCommand.ConsoleApp
{
    public class DefaultEventListener : IEventListener
    {
        public virtual void OnComplete(AppResult appResult)
        {
            switch (appResult.EvaluateResult.State)
            {
                case EvaluateState.Success:
                    if (!appResult.App.Console.ExitCodeHasValue)
                        appResult.App.Console.ExitCode = ExitCodeConstants.Success;

                    break;
                case EvaluateState.NotFound:
                    appResult.App.Console.ExitCode = ExitCodeConstants.Error;
                    this.ShowNotFound(appResult);
                    break;
                case EvaluateState.HasError:
                    appResult.App.Console.ExitCode = ExitCodeConstants.Error;
                    this.ShowErrors(appResult);
                    break;
                //case EvaluateState.HasInvalidArgument:
                //    eventArgs.App.Console.ExitCode = ExitCodeConstants.Error;
                //    break;
            }
        }

        public virtual void OnException(AppResult appResult, Exception ex)
        {
            throw ex;
        }

        public virtual void OnBeforeMemberInvoke(AppResult appResult, IMember member)
        {
            
        }

        public virtual void OnAfterMemberInvoke(AppResult appResult, IMember member)
        {

        }

        public virtual void OnMemberPrint(AppResult appResult, IMember method)
        {
            if (method.Value != null)
            {
                if (method.Value.GetType() != typeof(string) && typeof(IEnumerable).IsAssignableFrom(method.Value.GetType()))
                {
                    foreach (var value in (IEnumerable)method.Value)
                        appResult.App.Console.Write(value);
                }
                else
                {
                    appResult.App.Console.Write(method.Value);
                }
            }
        }

        public virtual void ShowNotFound(AppResult appResult)
        {
            appResult.App.Console.Error(Strings.NotFoundMessage, false);
        }

        public virtual void ShowErrors(AppResult appResult)
        {
            var commandsInvalid = appResult
                .ParseResult
                .Levels
                .Where(f => f.Commands.Empty(c => c.IsValid))
                .SelectMany(f => f.Commands)
                .Where(f => f.HasError);

            var groupByCommand = commandsInvalid.GroupBy(f => f.Command);

            var app = appResult.App;
            var count = groupByCommand.Count();

            var iErr = 0;
            foreach (var group in groupByCommand)
            {
                var propertiesInvalid = group.SelectMany(f => f.PropertiesInvalid);
                var methodsInvalid = group.SelectMany(f => f.MethodsInvalid);

                iErr++;

                var header = string.Format("There are errors in command: {0}", group.Key.GetType().Name);
                app.Console.Error(header);

                //var propertiesInvalid = command.PropertiesInvalid;
                if (propertiesInvalid.Any())
                    this.ShowInvalidProperties(app, propertiesInvalid);

                //var methodsInvalid = command.MethodsInvalid;
                if (methodsInvalid.Any())
                    this.ShowInvalidMethods(app, methodsInvalid);

                if (iErr < count)
                    app.Console.Write(string.Empty, true);
            }
        }

        private void ShowInvalidMethods(App app, IEnumerable<ActionMapped> methodsInvalid)
        {
            var iErr = 0;
            var count = methodsInvalid.Count();

            foreach (var invalid in methodsInvalid)
            {
                iErr++;

                var header = string.Format("Error in method: {0}", GetMethodSpecification(invalid.ActionMap));
                app.Console.Error(header);
                this.ShowInvalidProperties(app, invalid.Arguments);
                if (iErr < count)
                    app.Console.Write(string.Empty, true);
            }
        }

        private void ShowInvalidProperties(App app, IEnumerable<ArgumentMapped> properties)
        {
            foreach (var arg in properties)
            {
                var argErro = GetArgumentErrorDescription(arg);
                if (argErro != null)
                    app.Console.Error(string.Format("{0}", argErro));
            }
        }

        public static string GetMethodSpecification(ActionMap map)
        {
            var format = "{0}({1})";
            string args = null;
            foreach(var arg in map.ArgumentsMaps)
            {
                var typeName = AppHelpers.CSharpName(arg.Type);
                args += args == null ? typeName : ", " + typeName;
            }
            return string.Format(format, map.ActionName, args);
        }

        public static string GetArgumentErrorDescription(ArgumentMapped argumentMapped)
        {
            if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentAlreadyBeenSet))
                return string.Format("The argument '{0}' has already been set", argumentMapped.GetArgumentNameInputted());
            else if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentNotExistsByName))
                return string.Format("The argument '{0}' does not exist", argumentMapped.GetArgumentNameInputted());
            else if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentNotExistsByValue))
                return string.Format("Could not find an argument to the specified value: {0}", argumentMapped.Raw);
            else if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentIsRequired))
                return string.Format("The argument '{0}' is required", argumentMapped.GetArgumentNameInputted());
            else if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentHasInvalidInput))
                return string.Format("The argument '{0}' is invalid", argumentMapped.GetArgumentNameInputted());
            else if (argumentMapped.MappingStates.HasFlag(ArgumentMappingState.ArgumentHasUnsupportedType))
                return string.Format("The argument '{0}' is unsupported", argumentMapped.GetArgumentNameInputted());
            return null;
        }

        //public virtual void ShowArgumentsErrors()
        //{
        //    foreach (var arg in this.ArgumentsInvalids)
        //        Console.WriteLine("Error in argument: {0} - {1}", arg.Name, this.GetArgumentMappedErrorDescription(arg));
        //}

        //public virtual void ShowNotFound(string[] args)
        //{
        //    var maxLength = 40;
        //    var command = string.Join(" ", args);
        //    command = command.Length <= maxLength ? command : command.Substring(0, maxLength);
        //    Console.WriteLine("The command '{0}' was not found", command);
        //}

        //public virtual void ShowHelp()
        //{
        //    //var dic = new Dictionary<string, string>();
        //    //foreach (var cmd in this.Commands2)
        //    //{
        //    //    foreach (var opt in cmd.Parser.Options)
        //    //    {
        //    //        var key = "";
        //    //        if (!string.IsNullOrWhiteSpace(opt.ShortName) && !string.IsNullOrWhiteSpace(opt.LongName))
        //    //            key = "-" + opt.ShortName + ", --" + opt.LongName;
        //    //        else if (!string.IsNullOrWhiteSpace(opt.ShortName))
        //    //            key = "-" + opt.ShortName;
        //    //        else if (!string.IsNullOrWhiteSpace(opt.LongName))
        //    //            key = "--" + opt.LongName;

        //    //        dic[key] = opt.Description;
        //    //    }
        //    //}

        //    //if (dic.Count > 0)
        //    //    Console.WriteLine(AppHelpers.GetConsoleHelper(dic, 4));
        //}



    }
}