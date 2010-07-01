using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    [Command("save", "Saves the current document")]
    class SaveCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("Saving...");
        }
    }
}
