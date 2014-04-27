using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var dressClothesFactory = new DressClothesFactory();
            ShowWhatAmIWearingToday(dressClothesFactory);

            Console.WriteLine("");

            var casualClothesFactory = new CasualClothesFactory();
            ShowWhatAmIWearingToday(casualClothesFactory);

            Console.ReadKey();
        }

        private static void ShowWhatAmIWearingToday(IClothesFactory factory)
        {
            Console.WriteLine("Here's what I'm wearing today:");

            var shirt = factory.CreateShirt();
            shirt.DescribeShirt();

            var pants = factory.CreatePants();
            pants.DescribePants();
        }
    }
}
