﻿using System;

namespace SysCommand.ConsoleApp
{
    //[Command(OrderExecution = -1000)]
    public class ManagerCommand2 : CommandArguments<ManagerCommand2.Arguments>
    {
        public ManagerCommand2()
        {
            this.OrderExecution = int.MinValue;
        }

        public override void Load(string[] args)
        {
            base.Load(args);
            this.Parse();
            
            if (string.IsNullOrWhiteSpace(this.ArgsObject.Name))    
            {
                App333.Current.CurrentCommandName = App333.CommandNameDefault;
                if (args != null && args.Length > 0 && args[0].Length > 0 && args[0][0] != '-')
                    App333.Current.CurrentCommandName = args[0];
            }
            else
            {
                App333.Current.CurrentCommandName = this.ArgsObject.Name;
            }
        }

        public override void Execute()
        {
            if (this.ArgsObject.ShowAll)
                this.Show();

            if (!string.IsNullOrWhiteSpace(this.ArgsObject.Show))
                this.Show(this.ArgsObject.Show);

            if (this.ArgsObject.Save)
                this.Save();

            if (this.ArgsObject.Remove)
                this.Remove();
        }

        private void Save()
        {
            var histories = App333.Current.GetOrCreateObjectFile<CommandStorage>();

            if (!histories.All.ContainsKey(App333.Current.CurrentCommandName))
            {
                Console.WriteLine("The command has no argument to save.");
                App333.Current.StopPropagation();
                return;
            }

            App333.Current.SaveObjectFile<CommandStorage>(histories);
            App333.Current.StopPropagation();
            Console.WriteLine("The command '{0}' was successfully saved", App333.Current.CurrentCommandName);
        }

        private void Remove()
        {
            var histories = App333.Current.GetOrCreateObjectFile<CommandStorage>();

            if (!histories.All.ContainsKey(App333.Current.CurrentCommandName))
            {
                Console.WriteLine("Command name '{0}' dosen't exists", App333.Current.CurrentCommandName);
                App333.Current.StopPropagation();
                return;
            }

            histories.Remove(App333.Current.CurrentCommandName);
            App333.Current.SaveObjectFile<CommandStorage>(histories);
            App333.Current.StopPropagation();
            Console.WriteLine("The command '{0}' was successfully removed.", App333.Current.CurrentCommandName);
        }

        private void Show()
        {
            var histories = App333.Current.GetOrCreateObjectFile<CommandStorage>();
            if (histories.All.Count == 0)
            {
                Console.WriteLine("No command was found to display.");
                App333.Current.StopPropagation();
                return;
            }

            foreach (var commandKeyValue in histories.All)
            {   
                var argsOutput = "";
                foreach (var args in commandKeyValue.Value)
                {
                    argsOutput += argsOutput == "" ? args.Value.Command : " " + args.Value.Command;
                }

                Console.WriteLine("\"{0}\" {1}", commandKeyValue.Key, argsOutput);
            }

            App333.Current.StopPropagation();
        }

        private void Show(string commandName)
        {
            var histories = App333.Current.GetOrCreateObjectFile<CommandStorage>();
            if (histories == null)
                App333.Current.SaveObjectFile<CommandStorage>(new CommandStorage());

            if (!histories.All.ContainsKey(commandName))
            {
                Console.WriteLine("Command name '{0}' dosen't exists", commandName);
                App333.Current.StopPropagation();
                return;
            }

            var command = histories.All[commandName];
            var argsOutput = "";
            foreach (var args in command.Values)
            {
                argsOutput += argsOutput == "" ? args.Command : " " + args.Command;
            }

            Console.WriteLine("\"{0}\" {1}", commandName, argsOutput);
            App333.Current.StopPropagation();
        }

        #region Internal Parameters
        public class Arguments
        {
            [Argument(LongName = "cmd-name", Help = "Specify the command name")]
            public string Name { get; set; }

            [Argument(LongName = "cmd-save", Help = "Save current command to the history commands")]
            public bool Save { get; set; }

            [Argument(LongName = "cmd-remove", Help = "Remove current command from the history commands")]
            public bool Remove { get; set; }

            [Argument(LongName = "cmd-show-all", Help = "Show all commands from the history.")]
            public bool ShowAll { get; set; }

            [Argument(LongName = "cmd-show", Help = "Show the specific command, if exists, from the history.")]
            public string Show { get; set; }
        }
        #endregion
    }
}