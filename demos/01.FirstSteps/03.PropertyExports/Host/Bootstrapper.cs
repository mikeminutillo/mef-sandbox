using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    #region No Peeking

    [Export]
    class Bootstrapper
    {
        [Import("Repeat Count")]
        private int RepeatCount;

        [Import("Message")]
        private string Messsage;

        internal void Bootstrap()
        {
            for(int i = 0; i < RepeatCount; i++)
                Console.WriteLine(Messsage);
        }
    }

    #endregion
}
