﻿using SysCommand.ConsoleApp;
using SysCommand.Execution;
using SysCommand.Mapping;
using SysCommand.Parsing;
using System;

namespace SysCommand.Tests.UnitTests.Commands.T26
{
    public class Command6 : Command
    {
        public string PropertyValue { get; set; }

        public Command6()
        {
            this.EnablePositionalArgs = true;
        }

        [Action(IsDefault=true)]
        public string Default(int value)
        {
            var cur = this.CurrentMethodParse();
            return GetDebugName(this.CurrentMethodMap(), cur);
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