using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts
{
    public interface IFeedbackProvider
    {
        void ProvideFeedback(string format, params object[] args);
    }
}
