using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    #region RSN
   
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);

            var container = new CompositionContainer(catalog);

            try
            {
                container.GetExportedValue<Bootstrapper>().Bootstrap();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    #endregion
}
