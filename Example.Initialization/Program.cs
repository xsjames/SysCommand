﻿using System;
using SysCommand.ConsoleApp;

namespace Example.Initialization
{
    public class Program
    {
        //public static int Main(string[] args)
        //{
        //    return App.RunApplication(args);
        //}

        static void Main(string[] args)
        {
            var app = new App();
            app.Run(args);
        }
        
        public class FirstCommand : Command
        {
            public string FirstProperty
            {
                set
                {
                    App.Console.Write("FirstProperty");
                }
            }
        }

        public class SecondCommand : Command
        {
            public string SecondProperty
            {
                set
                {
                    App.Console.Write("SecondProperty");
                }
            }
        }
    }
}
