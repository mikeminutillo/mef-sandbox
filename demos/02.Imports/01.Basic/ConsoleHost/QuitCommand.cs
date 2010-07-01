using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace ConsoleHost
{
    class QuitCommand : IPlugin
    {
        public string Name
        {
            get { return "Quit"; }
        }

        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
