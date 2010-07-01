using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class Emailer : IPlugin
    {
        public string Name
        {
            get { return "Send Email"; }
        }

        public void Execute()
        {
            // Send emails!
        }
    }
}
