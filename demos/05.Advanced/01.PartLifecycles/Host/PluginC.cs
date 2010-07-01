using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(AnyPlugin))]
    [PartCreationPolicy(CreationPolicy.Any)]
    class AnyPlugin : IPlugin, IDisposable
    {
        private static int counter = 0;

        public AnyPlugin()
        {
            counter++;
        }

        public string Name
        {
            get { return "Plugin C"; }
        }

        public void Run()
        {
            Console.WriteLine("Running Any: {0}", counter);
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing Any");
        }
    }
}
