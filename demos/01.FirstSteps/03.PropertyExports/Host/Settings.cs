using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    // NOTE: This class is not itself exported
    class Settings
    {
        [Export("Repeat Count")]
        private int _counter = 5;

        [Export("Message")]
        private string _message = "Huzzah!";
    }
}
