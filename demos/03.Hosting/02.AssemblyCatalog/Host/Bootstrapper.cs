using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Bootstrapper
    {
        [ImportMany]
        public IEnumerable<IPlugin> Plugins;

        internal void Bootstrap()
        {
            Console.WriteLine("Plugins: {0}", String.Join(", ", Plugins.Select(x => x.Name)));
        }
    }
}
