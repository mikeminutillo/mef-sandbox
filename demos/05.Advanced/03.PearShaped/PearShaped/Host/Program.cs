using System;
using System.ComponentModel.Composition.Hosting;
using Host.Plugins;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
            var directoryCatalog = new DirectoryCatalog(".");
            var catalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);
            var container = new CompositionContainer(catalog);

            try
            {
                container.GetExportedValue<HomePageController>().Run();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
