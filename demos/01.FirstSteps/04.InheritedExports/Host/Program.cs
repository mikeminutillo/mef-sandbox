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
            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);

            var container = new CompositionContainer(assemblyCatalog);

            container.GetExportedValue<Program>().Run();
        }

        [ImportMany]
        private IEnumerable<IPlugin> _plugins;

        private void Run()
        {
            Console.WriteLine("Installed Plugins: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
        }
    }
}
