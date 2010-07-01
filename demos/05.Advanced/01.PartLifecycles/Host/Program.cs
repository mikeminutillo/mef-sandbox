using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            var container = new CompositionContainer(catalog);
            for (int i = 0; i < 3; i++)
                container.GetExportedValue<NonSharedPlugin>().Run();
            for (int i = 0; i < 3; i++)
                container.GetExportedValue<SharedPlugin>().Run();
            for (int i = 0; i < 3; i++)
                container.GetExportedValue<AnyPlugin>().Run();
            container.GetExportedValue<TesterAny>().Test();
            container.GetExportedValue<TesterShared>().Test();
            container.GetExportedValue<TesterNonShared>().Test();

            container.Dispose();
        }
    }
}
