using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Host;

namespace PackageA
{
    class Class2 : IPlugin
    {
        public string Name
        {
            get { return "Class 2"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
