namespace Prototype
{
    public class StreetSign
    {
        public StreetSign(string shape, string text)
        {
            Shape = shape;
            Text = text;
        }

        public string Text { get; private set; }
        public string Shape { get; private set; }

        public StreetSign Clone()
        {
            return new StreetSign(Shape, Text);
        }
    }
}
