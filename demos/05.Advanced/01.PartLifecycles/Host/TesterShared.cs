using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class TesterShared
    {
        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Shared)]
        NonSharedPlugin nonShared;

        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Shared)]
        SharedPlugin shared;

        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Shared)]
        AnyPlugin any;


        internal void Test()
        {
            Console.WriteLine("Shared->NonShared: {0}", nonShared);
            Console.WriteLine("Shared->Shared: {0}", shared);
            Console.WriteLine("Shared->Any: {0}", any);
        }
    }
}
