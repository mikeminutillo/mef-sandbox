using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    // NOTE: Metadata doesn't work for inherited exports
    [Export(typeof(ICommand))]
    [ExportMetadata("Name", "Help")]
    [ExportMetadata("Description", "Displays help for the system")]
    class HelpCommand : ICommand
    {
        public HelpCommand()
        {
            Console.WriteLine("--> Creating a new Help Command");
        }

        public void Execute()
        {
            Console.WriteLine("Help for the system");
            Console.WriteLine();
        }
    }
}
