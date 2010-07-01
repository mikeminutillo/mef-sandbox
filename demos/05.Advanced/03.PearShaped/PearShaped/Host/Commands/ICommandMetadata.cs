using System.ComponentModel;

namespace Host.Commands
{
    public interface ICommandMetadata
    {
        string Name { get; }
        [DefaultValue("No Description")]
        string Description { get; }
    }
}
