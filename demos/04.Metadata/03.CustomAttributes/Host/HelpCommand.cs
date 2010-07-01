using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Command("help", "displays the help", Important = true)]
    class HelpCommand : ICommand
    {
        public void Run()
        {
            Console.WriteLine("Help");
            _showUsage(false);
        }

        [Import("Show Usage")]
        Action<bool> _showUsage;
    }
}
