﻿using SysCommand.Parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SysCommand
{
    public class ArgumentAction : IMember
    {
        public ArgumentMapped ArgumentMapped { get; private set; }
        public MethodInfo MethodInfo { get; private set; }
        public string Name { get; private set; }
        public object Source { get; private set; }
        public object Value { get; set; }
        public bool IsInvoked { get; set; }

        public ArgumentAction(ArgumentMapped argumentMapped)
        {
            this.ArgumentMapped = argumentMapped;
            this.Name = this.ArgumentMapped.Name;

            if (argumentMapped.Map != null)
            { 
                this.MethodInfo = (MethodInfo)argumentMapped.Map.PropertyOrParameter;
                this.Value = argumentMapped.Value;
                this.Source = argumentMapped.Map.Source;
            }
        }

        public void Invoke()
        {
            this.MethodInfo.Invoke(Source, new[] { this.Value });
            this.IsInvoked = true;
        }
    }
}
