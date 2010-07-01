using System.ComponentModel.Composition;

namespace Host.Plugins
{
    [Export]
    class Emailer
    {
        //[Import(AllowDefault = true)]
        private Logger _logger;
    }
}
