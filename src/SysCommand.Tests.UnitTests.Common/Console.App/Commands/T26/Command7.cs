﻿using SysCommand.ConsoleApp;
using SysCommand.Parsing;
using SysCommand.Mapping;
using System;
using static SysCommand.Helpers.ReflectionHelper;

namespace SysCommand.Tests.UnitTests.Common.Commands.T26
{
    public class Command7 : Command
    {
        public string Prop { get; set; }

        public Command7()
        {
            this.EnablePositionalArgs = true;
        }

        [Action(IsDefault=true)]
        public string Default(int value = 100, int b = 200)
        {
            var cur = this.GetAction(T<int, int>());
            return GetDebugName(this.GetActionMap(T<int, int>()), cur);
        }

        private string GetDebugName(ActionMap map, ActionParsed parsed)
        {
            if (map != parsed.ActionMap)
                throw new Exception("There are errors in one of the methods: GetCurrentMethodMap() or GetCurrentMethodResult()");

            var specification = CommandParserUtils.GetMethodSpecification(parsed);
            return this.GetType().Name + "." + specification;
        }
    }
}
