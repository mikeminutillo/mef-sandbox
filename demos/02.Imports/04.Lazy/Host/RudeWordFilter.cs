using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class RudeWordFilter
    {
        public RudeWordFilter()
        {
            Console.WriteLine("RUDE WORDS DETECTED!");
        }

        private const string RudeWord = "@&$*%&$^!@&*$*&$^%!@&*$*&$^%!@&*$*&$^%!@&*";

        public string Convert(string rudeWord)
        {
            return RudeWord.Substring(0, rudeWord.Length);
        }
    }
}
