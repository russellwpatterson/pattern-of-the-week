namespace AbstractFactory
{
    public interface IClothesFactory
    {
        IShirt CreateShirt();
        IPants CreatePants();
    }

    public class DressClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new DressShirt();
        }

        public IPants CreatePants()
        {
            return new DressPants();
        }
    }

    public class CasualClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new TeeShirt();
        }

        public IPants CreatePants()
        {
            return new Jeans();
        }
    }
}
