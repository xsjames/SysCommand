﻿using System;
using System.Linq;
using System.Collections.Generic;
using SysCommand.ConsoleApp;
using SysCommand.Parser;

namespace SysCommand.Tests.UnitTests.Commands.T26
{
    public class Command1 : Command
    {
        public string a { get; set; }

        public string Main()
        {
            return "Main";
        }
    }
}
