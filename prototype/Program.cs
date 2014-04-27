using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var signs = new List<StreetSign>();
            var stopSign = new StreetSign("Octagon", "STOP");
            var yieldSign = new StreetSign("Triangle", "YIELD");

            // We need 10 stop signs for some new construction. Use the one we have as a template.
            for (var i = 0; i < 10; i++)
            {
                signs.Add(stopSign.Clone());
            }

            // We also need 5 yield signs. Use that one as a template too.
            for (var i = 0; i < 5; i++)
            {
                signs.Add(yieldSign.Clone());
            }

            foreach (var ss in signs)
            {
                Console.WriteLine("Sign: {0} ({1})", ss.Text, ss.Shape);
            }

            Console.Read();
        }
    }
}
