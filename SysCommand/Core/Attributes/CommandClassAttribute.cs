﻿using System;

namespace SysCommand
{
    public class CommandAttribute : Attribute
    {
        public int OrderExecution { get; set; }
        public bool OnlyInDebug { get; set; }
    }
}
