using System;
using System.ComponentModel.Composition;

namespace Host.Commands
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CommandAttribute : ExportAttribute
    {
        public CommandAttribute(string name)
            : base(typeof(ICommand))
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
