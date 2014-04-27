using System;
using TemplateMethod.Warriors;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var samurai = new Samurai();
            samurai.Attack();

            var grenadier = new Grenadier();
            grenadier.Attack();

            var infantry = new Infantry();
            infantry.Attack();

            Console.Read();
        }
    }
}
