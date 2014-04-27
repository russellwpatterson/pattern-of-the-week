using System;

namespace AbstractFactory
{
    public interface IPants
    {
        void DescribePants();
    }

    public class DressPants : IPants
    {
        public void DescribePants()
        {
            Console.WriteLine("Dress Pants: Wear these to professional encounters.");
        }
    }

    public class Jeans : IPants
    {
        public void DescribePants()
        {
            Console.WriteLine("Jeans: Wear these pretty much anywhere.");
        }
    }
}
