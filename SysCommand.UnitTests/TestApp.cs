﻿using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysCommand;

namespace SysCommand.UnitTests
{
    [TestClass]
    public class TestApp
    {
        [TestMethod]
        public void RunApp()
        {
            var commandLoader = new DefaultCommandLoader();
            //var app = new App2(commandLoader.GetFromAppDomain());
        }
    }

    
}
