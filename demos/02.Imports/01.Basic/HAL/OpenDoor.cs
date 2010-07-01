using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace HAL
{
    class OpenDoor : IPlugin
    {
        [Import]
        public IFeedbackProvider _feedbackProvider;

        public string Name
        {
            get { return "Open pod bay doors"; }
        }

        public void Execute()
        {
            _feedbackProvider.ProvideFeedback("I'm sorry, I can't do that Dave.");
        }
    }
}
