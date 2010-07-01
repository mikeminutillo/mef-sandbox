using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class PluginB : IPlugin
    {
        public string Name
        {
            get { return "Plugin B"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
