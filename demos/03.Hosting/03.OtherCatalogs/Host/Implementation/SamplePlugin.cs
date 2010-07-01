using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host.Implementation
{
    class SamplePlugin : IPlugin
    {
        public string Name
        {
            get { return "Sample"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
