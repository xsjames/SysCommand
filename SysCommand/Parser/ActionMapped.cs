﻿using System.Collections.Generic;
using System.Linq;
using System;
using Fclp;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Globalization;
using System.Collections;

namespace SysCommand.Parser
{
    public class ActionMapped
    {
        private List<ArgumentRaw> argumentsRaw;

        public string Name { get; private set; }
        public ActionMap ActionMap { get; private set; }
        public ArgumentRaw ArgumentRawOfAction { get; private set; }
        public IEnumerable<ArgumentMapped> Arguments { get; set; }
        public IEnumerable<ArgumentMapped> ArgumentsExtras { get; internal set; }
        public int Level { get; private set; }
        public ActionMappingState MappingStates { get; set; }

        public ActionMapped(string name, ActionMap actionMap, ArgumentRaw argumentRawOfAction, int level)
        {
            this.Name = name;
            this.ArgumentRawOfAction = argumentRawOfAction;
            this.ActionMap = actionMap;
            this.argumentsRaw = new List<ArgumentRaw>();
            this.Level = level;
        }

        public void AddArgumentRaw(ArgumentRaw argumentRaw)
        {
            this.argumentsRaw.Add(argumentRaw);
        }

        public IEnumerable<ArgumentRaw> GetArgumentsRaw()
        {
            return this.argumentsRaw;
        }

        public override string ToString()
        {
            return "[" + this.Name + "]";
        }
    }
}