using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    #region No Peeking

    class DelegatePlugin : IPlugin
    {
        private readonly string _name;
        private readonly Action _action;

        public DelegatePlugin(string name, Action action)
        {
            _name = name;
            _action = action;
        }

        public string Name { get { return _name; } }

        public void Execute()
        {
            _action();
        }
    }

    #endregion
}
