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

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Commands");
                Console.WriteLine("========");
                foreach (var command in _commands)
                {
                    Console.WriteLine("{0:-10}: {1}", command.Metadata.Name, command.Metadata.Description);
                }
                Console.Write("> ");
                var response = Console.ReadLine().Trim();
                Execute(response);                
            }
        }

        private void Execute(string response)
        {
            var command = _commands.FirstOrDefault(x => String.Equals(response, x.Metadata.Name, StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                Console.WriteLine("No such command");
            }
            else
            {
                command.Value.Execute();
            }
        }
    }
}
