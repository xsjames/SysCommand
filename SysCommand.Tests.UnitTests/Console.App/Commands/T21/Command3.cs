﻿using SysCommand.ConsoleApp;
using SysCommand.Execution;
using SysCommand.Mapping;
using SysCommand.Parsing;
using System;

namespace SysCommand.Tests.UnitTests.Commands.T21
{
    public class Command3 : Command
    {
        [Action(IsDefault = true)]
        public string Main(string value = null, string value2 = null)
        {
            var cur = this.CurrentMethodParse();
            return GetDebugName(this.CurrentMethodMap(), cur);
        }

        private string GetDebugName(ActionMap map, MethodResult result)
        {
            if (map != result.ActionParsed.ActionMap)
                throw new Exception("There are errors in one of the methods: GetCurrentMethodMap() or GetCurrentMethodResult()");

            var specification = CommandParserUtils.GetMethodSpecification(map);
            return this.GetType().Name + "." + specification;
        }
    }
}
