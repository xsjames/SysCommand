﻿using SysCommand.ConsoleApp;

namespace SysCommand.Tests.UnitTests.Common.Commands.T16
{
    public class Command3 : Command
    {
        public decimal Price { get; set; }
        public void Main()
        {
            App.Console.Write("Price=" + Price);
        }
    }
}
