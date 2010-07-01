using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class PluginC : IPlugin
    {
        public string Name
        {
            get { return "Plugin C"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
