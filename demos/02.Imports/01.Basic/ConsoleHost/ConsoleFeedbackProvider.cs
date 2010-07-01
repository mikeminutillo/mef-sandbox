using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace ConsoleHost
{
    [Export(typeof(IFeedbackProvider))]
    class ConsoleFeedbackProvider : IFeedbackProvider
    {
        public void ProvideFeedback(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
