﻿using SysCommand.Parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SysCommand
{
    public class Property : IMember
    {
        public ArgumentMapped ArgumentMapped { get; private set; }
        public PropertyInfo PropertyInfo { get; private set; }
        public string Name { get; private set; }
        //public string Alias { get; private set; }
        public object Source { get; private set; }
        public object Value { get; set; }
        public bool IsInvoked { get; set; }

        public Property(ArgumentMapped argumentMapped/*, int invokePriority*/)
        {
            this.ArgumentMapped = argumentMapped;
            this.Name = this.ArgumentMapped.Name;

            if (argumentMapped.Map != null)
            { 
                this.PropertyInfo = (PropertyInfo)argumentMapped.Map.PropertyOrParameter;
                this.Value = argumentMapped.Value;
                this.Source = argumentMapped.Map.Source;
                //this.Name = this.ArgumentMapped.Map.MapName;
            }
        }

        public Property(string name, string alias, object source, PropertyInfo property, object value, int invokePriority)
        {
            this.PropertyInfo = property;
            this.Value = value;
            this.Source = source;
            this.Name = name;
            //this.Alias = alias;
        }

        public void Invoke()
        {
            this.PropertyInfo.SetValue(Source, this.Value);
            this.IsInvoked = true;
        }
    }
}
