using System.ComponentModel.Composition;

namespace Host.Plugins
{
    [Export]
    class Notifications
    {
        [Import]
        private Emailer _emailer;
    }
}
