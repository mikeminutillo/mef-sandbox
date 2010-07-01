using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace HAL
{
    public class Sing : IPlugin
    {
        [Import]
        public IFeedbackProvider _feedbackProvider;

        public string Name
        {
            get { return "Sing"; }
        }

        public void Execute()
        {
            _feedbackProvider.ProvideFeedback("Daisy, Daisy, Give me your answre do");
        }
    }
}
