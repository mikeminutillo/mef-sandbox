using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Bootstrapper
    {
        [ImportMany]
        public IEnumerable<Lazy<ICommand, ICommandMetadata>> _commands;


        internal void Run()
        {
            ShowUsage(importantOnly: true);
            while (true)
            {
                Console.Write("> ");
                var response = Console.ReadLine().Trim();
                Execute(response);
            }
        }

        private void Execute(string response)
        {
            var command = _commands.FirstOrDefault(x => String.Equals(x.Metadata.Name, response, StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                Console.WriteLine("Not sure how to do that!");
                ShowUsage(importantOnly: true);
            }
            else
            {
                command.Value.Run();
            }
        }

        [Export("Show Usage")]
        private void ShowUsage(bool importantOnly = false)
        {
            var commands = _commands;
            if (importantOnly) 
                commands = commands.Where(x => x.Metadata.Important);

            foreach (var command in commands)
            {
                Console.WriteLine("{0:30}: {1}", command.Metadata.Name, command.Metadata.Description);
            }
        }
    }
}
