﻿using System;
using System.Linq;
using System.Collections.Generic;
using SysCommand.ConsoleApp;
using SysCommand.Parsing;
using SysCommand.Mapping;
using SysCommand.Execution;

namespace SysCommand.Tests.ConsoleApp.Commands
{
    public class Command3 : Command
    {
        public bool ShowTime { get; set; }

        public Command3()
        {
            this.EnablePositionalArgs = true;
        }

        public string Main()
        {
            return this.GetType().Name + ".Main";
        }

        public string Main(string value)
        {
            return GetDebugName(this.CurrentMethodMap(), this.CurrentMethodParse());
        }

        [Action(IsDefault = true)]
        public string Default(string value)
        {
            return GetDebugName(this.CurrentMethodMap(), this.CurrentMethodParse());
        }

        public string Save()
        {
            return GetDebugName(this.CurrentMethodMap(), this.CurrentMethodParse());
        }

        public string Delete(string title = null, string description = null, DateTime? date = null)
        {
            return GetDebugName(this.CurrentMethodMap(), this.CurrentMethodParse());
        }

        private string GetDebugName(ActionMap map, MethodResult result)
        {
            if (map != result.ActionParsed.ActionMap)
                throw new Exception("There are errors in one of the methods: GetCurrentMethodMap() or GetCurrentMethodResult()");

            var specification = App.Descriptor.GetMethodSpecification(map);
            return this.GetType().Name + "." + specification;
        }
    }
}
