﻿using System;
using System.Linq;
using System.Collections.Generic;
using SysCommand.ConsoleApp;
using SysCommand.Parser;

namespace SysCommand.Tests.UnitTests.Commands.T11
{
    public class Command3 : Command
    {
        public decimal Price { get; set; }
        public int Id { get; set; }

        public Command3()
        {
            this.EnablePositionalArgs = true;
        }

        public string Main()
        {
            return this.GetType().Name + string.Format(".Main() = Price={0}, Id={1}", Price, Id);
        }

        public string Save(int a, int b)
        {
            var cur = this.CurrentMethodResult();
            return GetDebugName(this.CurrentMethodMap(), cur) + " Level" + cur.ActionMapped.Level;
        }

        private string GetDebugName(ActionMap map, Method result)
        {
            if (map != result.ActionMapped.ActionMap)
                throw new Exception("There are errors in one of the methods: GetCurrentMethodMap() or GetCurrentMethodResult()");

            var specification = DefaultEventListener.GetMethodSpecification(map);
            return this.GetType().Name + "." + specification;
        }
    }
}