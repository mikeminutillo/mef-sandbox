using System.ComponentModel.Composition;

namespace Host.Plugins
{
    [Export]
    public class Security
    {
        [Import]
        private ActiveDirectory _ad;
    }
}
