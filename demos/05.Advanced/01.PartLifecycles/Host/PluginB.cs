using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(SharedPlugin))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class SharedPlugin : IPlugin, IDisposable
    {
        private static int counter = 0;

        public SharedPlugin()
        {
            counter++;
        }

        public string Name
        {
            get { return "Plugin B"; }
        }

        public void Run()
        {
            Console.WriteLine("Running Shared: {0}", counter);
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Shared");
        }
    }
}
