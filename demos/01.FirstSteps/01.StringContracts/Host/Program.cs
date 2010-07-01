using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    // Export "plugin" to extend this thingy

    #region MAGIC HAPPENS HERE

    class Program
    {
        static void Main(string[] args)
        {
            var container = new CompositionContainer(new DirectoryCatalog("."));

            var plugins = container.GetExportedValues<object>("plugin");

            Console.WriteLine("Installed Plugins");
            Console.WriteLine("-===============-");
            Console.WriteLine(String.Join(Environment.NewLine, plugins.Select(x => x.ToString())));
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    #endregion
}
