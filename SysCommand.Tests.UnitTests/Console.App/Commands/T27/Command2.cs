﻿using System;
using System.Linq;
using System.Collections.Generic;
using SysCommand.ConsoleApp;
using SysCommand.Parsing;
using SysCommand.Mapping;

namespace SysCommand.Tests.UnitTests.Commands.T27
{
    public class Command2 : Command
    {
        public Command2()
        {
            this.EnablePositionalArgs = true;
        }

        public string Main(string[] a)
        {
            return $"Main(string[] a)";
        }

        public string Main(int a, int b)
        {
            return $"Main({a}, {b})";
        }
    }
}
