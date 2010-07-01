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
        public IEnumerable<Lazy<ICommand, IDictionary<string, object>>> _commands;

        internal void Run()
        {
            while (true)
            {
                Console.WriteLine("Commands");
                Console.WriteLine("========");
                foreach (var command in _commands)
                {
                    var commandName = (string)command.Metadata["Name"];
                    var commandDesc = (string)command.Metadata["Description"];
                    Console.WriteLine("{0:-10}: {1}", commandName, commandDesc);
                }
                Console.Write("> ");
                var response = Console.ReadLine().Trim();
                Execute(response);
            }

        }

        private void Execute(string response)
        {
            var command = _commands.FirstOrDefault(x => String.Equals(response, (string)x.Metadata["Name"], StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                Console.WriteLine("No such command");
            }
            else
            {
                command.Value.Run();
            }
        }
    }
}
