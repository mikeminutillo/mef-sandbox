using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    public interface ICommandMetadata
    {
        string Name { get; }
        string Description { get; }
        bool Important { get; }
    }
}
