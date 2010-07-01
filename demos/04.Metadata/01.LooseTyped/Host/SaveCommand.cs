using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(ICommand))]
    [ExportMetadata("Name", "Save")]
    [ExportMetadata("Description", "Saves the current document")]
    class SaveCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("Saving...");
        }
    }
}
