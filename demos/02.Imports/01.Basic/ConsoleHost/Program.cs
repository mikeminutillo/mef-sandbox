using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Contracts;

namespace ConsoleHost
{
    #region Not yet!

    [Export]
    class Program
    {
        static void Main(string[] args)
        {
            var directoryCatalog = new DirectoryCatalog(".");
            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            container.GetExportedValue<Program>().Run(directoryCatalog);
        }

        [ImportMany(AllowRecomposition=true)]
        private IEnumerable<IPlugin> _plugins;

        [Import(typeof(IFeedbackProvider))]
        private IFeedbackProvider _feedbackProvider;

        private void Run(DirectoryCatalog catalog)
        {
            while (true)
            {
                _feedbackProvider.ProvideFeedback("Options: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
                _feedbackProvider.ProvideFeedback("What now!");
                var response = Console.ReadLine().Trim();
                Execute(response);
                catalog.Refresh();
            }
        }

        private void Execute(string response)
        {
            var plugin = _plugins.FirstOrDefault(x => String.Equals(x.Name, response, StringComparison.InvariantCultureIgnoreCase));
            if (plugin == null)
                _feedbackProvider.ProvideFeedback("I don't understand that!");
            else
                plugin.Execute();
        }
    }

    #endregion
}
