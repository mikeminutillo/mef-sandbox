using System;
using Host.Commands;

namespace MyCommands
{
    [Command("help")]
    public class HelpCommand : ICommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
