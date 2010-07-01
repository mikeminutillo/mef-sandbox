using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Contracts;

namespace WinFormsHost
{
    [Export]
    class CommandRunner
    {
        [ImportMany(AllowRecomposition=true)]
        private IEnumerable<IPlugin> _plugins;

        [Import]
        IFeedbackProvider _feedbackProvider;

        public void ExecuteCommand(string command)
        {
            var plugin = _plugins.FirstOrDefault(x => String.Equals(command, x.Name, StringComparison.InvariantCultureIgnoreCase));

            if (plugin == null)
                _feedbackProvider.ProvideFeedback("I don't know how to {0}. Try 'list' for a list of commands", command);
            else
                plugin.Execute();

        }

    }
}
