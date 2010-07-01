using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace WinFormsHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetShadowCopyFiles();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var assemblyCatalog = new AssemblyCatalog(typeof(Program).Assembly);
            var directoryCatalog = new DirectoryCatalog(".");
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog, directoryCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            var batch = new CompositionBatch();
            batch.AddExportedValue<Action>("Refresh", directoryCatalog.Refresh);
            container.Compose(batch);

            var form = container.GetExportedValue<Form>("Main");

            Application.Run(form);
        }
    }
}
