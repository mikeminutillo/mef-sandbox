using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    class SomePlugin : IPlugin
    {
        [Import(AllowDefault = true)]
        private ILogger _log;

        public string Name
        {
            get { return "Some Plugin"; }
        }

        public void Execute()
        {
            if (_log != null) _log.Log("Starting Plugin!");
            Console.WriteLine("Do stuff");
            if (_log != null) _log.Log("Finished!");
        }
    }
}
