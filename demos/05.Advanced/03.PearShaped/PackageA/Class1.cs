using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Host;

namespace PackageA
{
   
    public class Class1 : IPlugin
    {
        public string Name
        {
            get { return "Part 1"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
