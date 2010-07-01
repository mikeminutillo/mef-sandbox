using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(ICommand))]
    [ExportMetadata("Name", "Help")]
    [ExportMetadata("Description", "Displays help")]
    class HelpCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("HEEEEEELLLLLP!");
        }
    }
}
