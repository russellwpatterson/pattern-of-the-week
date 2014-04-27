using System;
using System.Security;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var proxy = new SomeServiceProxy();

                var strings = proxy.GetStrings();

                foreach (var s in strings)
                    Console.WriteLine(s);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.ReadKey();
        }
    }
}

