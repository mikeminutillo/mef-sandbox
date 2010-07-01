using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Bootstrapper
    {
        #region FAIL Implementation

        //[Import]
        //private IPlugin somePlugin;

        //public void Bootstrap()
        //{
        //    Console.WriteLine(somePlugin.Name);
        //}

        #endregion

        #region WIN Implementation

        [ImportMany]
        private IEnumerable<IPlugin> _plugins;

        public void Bootstrap()
        {
            Console.WriteLine(_plugins.First().Name);
        }

        #endregion
    }
}
