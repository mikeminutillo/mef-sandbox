using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(ICommand))]
    [ExportMetadata("Name", "New")]
    [ExportMetadata("Description", "Creates a new Document")]
    class NewCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("Creating a new document");
        }
    }
}
