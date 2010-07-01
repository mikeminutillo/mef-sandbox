using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Host
{
    class Hawaii : IPlugin
    {
        public string Name
        {
            get { return "Hawaii"; }
        }

        public void Execute()
        {
            Console.WriteLine("Aloha Cousins!"); 
        }
    }
}
