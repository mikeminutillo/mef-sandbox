using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class Ftp : IPlugin
    {
        public string Name
        {
            get { return "FTP Server"; }
        }

        public void Execute()
        {
            // Host an awesome FTP site!
        }
    }
}
