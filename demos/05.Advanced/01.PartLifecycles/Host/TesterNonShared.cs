using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class TesterNonShared
    {
        [Import(AllowDefault = true, RequiredCreationPolicy=CreationPolicy.NonShared)]
        NonSharedPlugin nonShared;

        [Import(AllowDefault = true, RequiredCreationPolicy=CreationPolicy.NonShared)]
        SharedPlugin shared;

        [Import(AllowDefault = true, RequiredCreationPolicy = CreationPolicy.NonShared)]
        AnyPlugin any;


        internal void Test()
        {
            Console.WriteLine("NonShared->NonShared: {0}", nonShared);
            Console.WriteLine("NonShared->Shared: {0}", shared);
            Console.WriteLine("NonShared->Any: {0}", any);
        }
    }
}
