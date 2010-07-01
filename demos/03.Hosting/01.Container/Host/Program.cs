using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Host
{
    // BEHOLD!

    class Program
    {
        static void Main(string[] args)
        {
            var container = new CompositionContainer();

            var hawaii = new Hawaii();
            var australia = new Australia();
            var bootstrapper = new Bootstrapper();

            container.ComposeParts(hawaii, australia, bootstrapper);
            bootstrapper.Run();

            Console.ReadLine();
            Console.WriteLine("Adding in a logger and running again");

            container.ComposeParts(new ConsoleLogger());
            bootstrapper.Run();
        }
    }
}
