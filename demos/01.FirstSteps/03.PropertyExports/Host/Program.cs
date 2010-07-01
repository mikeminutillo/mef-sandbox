using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    #region We'll lift the curtain soon  // I'm really only hiding 3 lines from you this time ;)

    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            var container = new CompositionContainer(catalog);
            container.GetExportedValue<Bootstrapper>().Bootstrap();
        }
    }

    #endregion
}
