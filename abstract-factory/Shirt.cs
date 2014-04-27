using System;

namespace AbstractFactory
{
    public interface IShirt
    {
        void DescribeShirt();
    }

    public class DressShirt : IShirt
    {
        public void DescribeShirt()
        {
            Console.WriteLine("Dress Shirt: Best for special occasions.");
        }
    }

    public class TeeShirt : IShirt
    {
        public void DescribeShirt()
        {
            Console.WriteLine("T-Shirt: Good for a casual day.");
        }
    }
}
