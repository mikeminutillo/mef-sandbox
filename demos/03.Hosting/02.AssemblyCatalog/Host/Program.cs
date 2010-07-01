using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    // Remember the three lines!

    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            var container = new CompositionContainer(catalog);
            container.GetExportedValue<Bootstrapper>().Bootstrap();
        }
    }
}
