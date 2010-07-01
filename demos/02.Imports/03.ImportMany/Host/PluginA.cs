using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class PluginA : IPlugin
    {
        public string Name
        {
            get { return "Plugin A"; }
        }

        public void Execute()
        {
            // Do thing A!
        }
    }
}
