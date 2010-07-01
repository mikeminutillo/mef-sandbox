using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [InheritedExport]
    interface ILogger
    {
        void Log(string message);
    }
}
