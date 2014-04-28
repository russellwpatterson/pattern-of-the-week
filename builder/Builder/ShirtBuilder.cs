using System.Drawing;

namespace Builder
{
    public interface IShirtBuilder
    {
        Color ShirtColor { get; set; }
        int ShirtSize { get; set; }
        ShirtBuilder.IShirt Build();
    }

    public class ShirtBuilder : IShirtBuilder
    {
        public ShirtBuilder()
        {
            this.ShirtColor = Color.Black;
            this.ShirtSize = 1;
        }

        public Color ShirtColor { get; set; }
        public int ShirtSize { get; set; }

        public IShirt Build()
        {
            // We could create any type here that implements IShirt.
            var shirt = new Shirt();
            shirt.Color = this.ShirtColor;
            shirt.Size = this.ShirtSize;

            return shirt;
        }

        public interface IShirt
        {
            Color Color { get; set; }
            int Size { get; set; }
        }

        private class Shirt : IShirt
        {
            public Color Color { get; set; }
            public int Size { get; set; }
        }
    }
}
