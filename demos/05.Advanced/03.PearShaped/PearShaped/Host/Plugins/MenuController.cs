using System.ComponentModel.Composition;

namespace Host.Plugins
{
    [Export]
    class MenuController
    {
        [Import]
        private Security _security;
    }
}
