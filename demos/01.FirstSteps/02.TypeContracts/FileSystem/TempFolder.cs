using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Host;
using System.ComponentModel.Composition;

namespace FileSystem
{
    [Export(typeof(IPlugin))]
    public class TempFolder : IPlugin
    {
        public string Name
        {
            get { return "Temp"; }
        }

        public void Execute()
        {
            Console.WriteLine("Your temp folder is at: {0}", Environment.GetEnvironmentVariable("TEMP"));
        }
    }
}
