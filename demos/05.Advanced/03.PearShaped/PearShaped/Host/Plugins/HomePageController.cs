using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Host.Commands;

namespace Host.Plugins
{
    [Export]
    class HomePageController
    {
        [Import]
        private Badges _badges;

        [Import]
        private MenuController _menu;

        [Import(AllowDefault = true)]
        private Logger _logger;

        [ImportMany]
        public IEnumerable<Lazy<ICommand, ICommandMetadata>> _commands;

        public void Run()
        {
            Console.WriteLine("Installed Commands: {0}", String.Join(", ", _commands.Select(x => x.Metadata.Name)));
        }
    }
}
