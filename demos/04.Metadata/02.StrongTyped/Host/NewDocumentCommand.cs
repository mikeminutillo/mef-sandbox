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
    class NewDocumentCommand : ICommand
    {
        public NewDocumentCommand()
        {
            Console.WriteLine("--> Creating a new New Document command");
        }

        public void Execute()
        {
            Console.WriteLine("Creating new document...");
            Console.WriteLine();
        }
    }
}
