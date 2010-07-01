using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Bootstrapper : IPartImportsSatisfiedNotification
    {
        [ImportMany(AllowRecomposition=true)]
        private IEnumerable<IPlugin> _plugins;

        [Import(AllowDefault=true, AllowRecomposition=true)]
        private ILogger _logger;

        internal void Run()
        {
            if( _logger != null) _logger.Log("Running Now!");
            Console.WriteLine("Installed Plugins: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
        }

        public void OnImportsSatisfied()
        {
            Console.WriteLine("(RE-)COMPOSED!");
        }
    }
}
