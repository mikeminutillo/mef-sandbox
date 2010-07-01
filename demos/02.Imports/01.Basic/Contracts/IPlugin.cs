using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Contracts
{

    [InheritedExport(typeof(IPlugin))]
    public interface IPlugin
    {
        string Name { get; }
        void Execute();
    }
}
