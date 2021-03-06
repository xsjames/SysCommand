﻿using System;
using SysCommand.ConsoleApp;
using SysCommand.Mapping;
using SysCommand.Parsing;
using static SysCommand.Helpers.ReflectionHelper;

namespace SysCommand.Tests.UnitTests.Common.Commands.T33
{
    public class Command3 : Command
    {
        [Action(IsDefault = true)]
        public string Method3(
            [Argument(ShortName = 'a', LongName = "p1")] int a,
            [Argument(ShortName = 'b', LongName = "p2")] int b = 2
        )
        {
            return GetDebugName(this.GetActionMap(T<int, int>()), this.GetAction(T<int, int>()));
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
