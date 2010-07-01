using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    class Bootstrapper
    {
        [ImportMany(AllowRecomposition=true)]
        public IEnumerable<IPlugin> _plugins;

        public void Run()
        {
            foreach (var plugin in _plugins)
            {
                plugin.Execute();
            }
        }
    }
}
