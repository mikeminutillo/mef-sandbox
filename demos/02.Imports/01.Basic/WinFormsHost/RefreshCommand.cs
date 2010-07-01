using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace WinFormsHost
{
    class RefreshCommand : IPlugin
    {
        [Import("Refresh")]
        Action _refresh;

        [Import]
        IFeedbackProvider _feedbackProvider;

        public string Name
        {
            get { return "Refresh"; }
        }

        public void Execute()
        {
            _refresh();
            _feedbackProvider.ProvideFeedback("Plugins refreshed. Try 'list' for a list of commands");
        }
    }
}
