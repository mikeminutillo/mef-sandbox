using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace Wargames
{
    public class Chess : IPlugin
    {
        [Import(typeof(IFeedbackProvider))]
        private IFeedbackProvider _feedbackProvider;

        public string Name
        {
            get { return "Chess"; }
        }

        public void Execute()
        {
            _feedbackProvider.ProvideFeedback("How about a nice game of Thermo-Nuclear Global Warfare?");
        }
    }
}
