using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Host;
using System.ComponentModel.Composition;

namespace FileSystem
{
    [Export(typeof(IPlugin))]
    class HomeFolder : IPlugin
    {
        public string Name
        {
            get { return "Home"; }
        }

        public void Execute()
        {
            Console.WriteLine("Home folder: {0}", Environment.GetEnvironmentVariable("HOME"));
        }
    }
}
