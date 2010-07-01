using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    class Australia : IPlugin
    {
        [Import(AllowDefault = true, AllowRecomposition = true)]
        private ILogger _logger;

        public string Name
        {
            get { return "Australia"; }
        }

        public void Execute()
        {
            if (_logger != null) _logger.Log("Now Entering Australia");
            Console.WriteLine("G'day mate");
        }
    }
}
