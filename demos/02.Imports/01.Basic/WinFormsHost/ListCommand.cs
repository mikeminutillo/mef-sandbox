using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace WinFormsHost
{
    class ListCommand : IPlugin
    {
        [ImportMany(AllowRecomposition = true)]
        public IEnumerable<IPlugin> _plugins;

        [Import]
        IFeedbackProvider _feedbackProvider;

        public string Name
        {
            get { return "List"; }
        }

        public void Execute()
        {
           _feedbackProvider.ProvideFeedback("Commands: {0}", String.Join(", ", _plugins.Select(x => x.Name)));
        }
    }
}
