using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    [Command("new", "Creates a new document", Important = true)]
    class NewDocumentCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("Creating a new document...");
        }
    }
}
