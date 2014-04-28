using System;
using System.Drawing;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ShirtBuilder();

            builder.ShirtColor = Color.Blue;
            builder.ShirtSize = 45;

            var shirt = builder.Build();

            Console.WriteLine("Color: " + shirt.Color.ToString());
            Console.WriteLine("Size: " + shirt.Size.ToString());

            Console.Read();
        }
    }
}
