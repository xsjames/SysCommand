﻿using Fclp;
using System;
using System.Linq.Expressions;

namespace SysCommand
{
    [CommandClassAttribute(OrderExecution = -1)]
    public class ClearCommand : Command<ClearCommand.Arguments>
    {
        public override void Execute()
        {
            if (this.Args.Clear)
                Console.Clear();
        }

        #region Internal Parameters
        public class Arguments
        {
            [CommandPropertyAttribute(LongName = "clear", Help = "Clear the prompt")]
            public bool Clear { get; set; }
        }
        #endregion
    }
}
