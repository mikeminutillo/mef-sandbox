using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    public interface ICommandMetadata
    {
        string Name { get; }
        string Description { get; }
    }
}
