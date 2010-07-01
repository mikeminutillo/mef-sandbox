using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetShadowCopyFiles();

            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
            var directoryCatalog = new DirectoryCatalog(".");
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            container.GetExportedValue<Program>().Run(directoryCatalog.Refresh);
        }

        public void Run(Action refresh)
        {
            while (true)
            {
                Console.WriteLine("Installed Plugins: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
                Console.WriteLine("Press enter to refresh");
                refresh();
                Console.ReadLine();
            }
        }

        [ImportMany(AllowRecomposition = true)]
        private IEnumerable<IPlugin> _plugins;
    }
}
