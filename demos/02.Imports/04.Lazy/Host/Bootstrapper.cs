using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Host
{
    [Export]
    class Bootstrapper
    {
        public void Run()
        {
            string response;
            do
            {
                response = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("You said '{0}'", Cleanup(response));
            } while (response != "quit");
        }

        private string Cleanup(string response)
        {
            var cleanedUp = response;
            foreach (var word in RudeWords)
            {
                if (cleanedUp.Contains(word))
                    cleanedUp = cleanedUp.Replace(word, _rudeWordFilter.Value.Convert(word));
            }
            return cleanedUp;
        }

        [Import]
        Lazy<RudeWordFilter> _rudeWordFilter;

        private IList<string> RudeWords = new List<string>
        {
            "bugger", "bum", "poo"
        };
    }
}
