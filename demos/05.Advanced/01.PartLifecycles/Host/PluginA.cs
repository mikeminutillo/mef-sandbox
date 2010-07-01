using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export(typeof(NonSharedPlugin))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class NonSharedPlugin : IPlugin, IDisposable
    {
        private static int counter = 0;

        public NonSharedPlugin()
        {
            counter++;
        }

        public string Name
        {
            get { return "Plugin A"; }
        }

        public void Run()
        {
            Console.WriteLine("Running NonShared: {0}", counter);
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing NonShared");
        }
    }
}
