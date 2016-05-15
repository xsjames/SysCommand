﻿using Fclp;
using System;

namespace SysCommand
{
    public interface ICommand
    {
        bool HasParsed { get; }
        FluentCommandLineParser Parser { get; }
        ICommandLineParserResult ParserResult { get; }
        void ParseArgs(string[] args);
        void Execute();
    }
}
