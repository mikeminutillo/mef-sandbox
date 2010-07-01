using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace Host
{
    // Export typeof(IPlugin) to extend this one

    #region Even More Magic! // Actually its basically the same magic
    
    [Export]
    class Program
    {
        static void Main(string[] args)
        {
            var directoryCatalog = new DirectoryCatalog(".");
            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            var batch = new CompositionBatch();
            batch.AddExportedValue<IPlugin>(new DelegatePlugin("Exit", () => Environment.Exit(0)));
            batch.AddExportedValue<IPlugin>(new DelegatePlugin("Refresh", directoryCatalog.Refresh));
            container.Compose(batch);

            container.GetExportedValue<Program>().Run();
        }

        [ImportMany(AllowRecomposition = true)]
        public IEnumerable<IPlugin> _plugins;

        private void Run()
        {
            while (true)
            {
                Console.WriteLine("Options: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
                Console.Write("What do you want to do?: ");
                var selection = Console.ReadLine().Trim();
                Run(selection);
            }
        }

        private void Run(string selection)
        {
            var plugin = _plugins.FirstOrDefault(x => String.Equals(x.Name, selection, StringComparison.InvariantCultureIgnoreCase));
            if (plugin == null)
                Console.WriteLine("*** Not sure how to do that ***");
            else
                plugin.Execute();
        }
    }

    #endregion
}
