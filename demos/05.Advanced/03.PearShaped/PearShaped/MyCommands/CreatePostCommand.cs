using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Host.Commands;
using Host.Plugins;

namespace MyCommands
{
    [Command("create_post")]
    class CreatePostCommand : ICommand
    {
        [Import]
        private Security _security;

        [Import]
        private Logger _logger;

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
