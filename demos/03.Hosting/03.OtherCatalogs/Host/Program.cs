using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using Host.Implementation;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryCatalog = new DirectoryCatalog("Plugins");
            var typeCatalog = new TypeCatalog(GetInternalPluginTypes());
            var aggregateCatalog = new AggregateCatalog(typeCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            container.GetExportedValue<Bootstrapper>().Run();

            Console.ReadLine();
        }

        private static IEnumerable<Type> GetInternalPluginTypes()
        {
            return typeof(Program).Assembly.GetTypes()
                                  .Where(x => x.Namespace.Contains("Implementation"));
        }
    }
}
