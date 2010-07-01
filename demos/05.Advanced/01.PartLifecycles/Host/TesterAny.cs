using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class TesterAny
    {
        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Any)]
        NonSharedPlugin nonShared;

        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Any)]
        SharedPlugin shared;

        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.Any)]
        AnyPlugin any;


        internal void Test()
        {
            Console.WriteLine("Any->NonShared: {0}", nonShared);
            Console.WriteLine("Any->Shared: {0}", shared);
            Console.WriteLine("Any->Any: {0}", any);
        }
    }
}
