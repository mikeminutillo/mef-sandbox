using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;

namespace Host
{
    class Program
    {
        static ComposablePart a;
        static ComposablePart b;
        static ComposablePart c;
        static Bootstrapper bootstrapper = new Bootstrapper();
        static ILogger logger = new ConsoleLogger();

        static void Main(string[] args)
        {
            var container = new CompositionContainer();
            ComposeBatchOne(container);
            container.GetExportedValue<Bootstrapper>().Run();
            ComposeBatchTwo(container);
            container.GetExportedValue<Bootstrapper>().Run();
        }

        private static void ComposeBatchOne(CompositionContainer container)
        {
            var batch = new CompositionBatch();
            
            a = batch.AddPart(new PluginA());
            b = batch.AddPart(new PluginB());

            batch.AddPart(bootstrapper);

            container.Compose(batch);
        }

        private static void ComposeBatchTwo(CompositionContainer container)
        {
            var batch = new CompositionBatch();
            batch.RemovePart(a);
            c = batch.AddPart(new PluginC());
            batch.AddPart(logger);

            container.Compose(batch);
        }
    }
}
