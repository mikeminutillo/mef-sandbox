using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class CommandAttribute : ExportAttribute, ICommandMetadata
        {
        public CommandAttribute(string name, string description) : base(typeof(ICommand))
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool Important { get; set; }
    }
}
