using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host.Implementation
{
    [Export]
    class Bootstrapper
    {
        [ImportMany]
        public IEnumerable<IPlugin> _plugins;

        public void Run()
        {
            Console.WriteLine("Installed Plugins: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
        }
    }
}
