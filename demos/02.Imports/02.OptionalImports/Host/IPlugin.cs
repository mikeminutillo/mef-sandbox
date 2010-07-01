using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [InheritedExport(typeof(IPlugin))]
    interface IPlugin
    {
        string Name { get; }
        void Execute();
    }
}
