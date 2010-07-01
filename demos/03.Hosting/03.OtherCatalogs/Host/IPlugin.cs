using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [InheritedExport]
    public interface IPlugin
    {
        string Name { get; }
        void Execute();
    }
}
