using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Host;

namespace ConsoleBits
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
