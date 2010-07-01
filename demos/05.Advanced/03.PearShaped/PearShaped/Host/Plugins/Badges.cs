using System.ComponentModel.Composition;

namespace Host.Plugins
{
    [Export]
    class Badges
    {
        [Import]
        private Security _security;

        [Import]
        private Notifications _notifications;
    }
}
