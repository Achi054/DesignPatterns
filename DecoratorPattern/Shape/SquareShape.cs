using DecoratorPattern.Shape;

namespace DecoratorPattern.Shape
{
    public class SquareShape : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Square is drawn");
        }
    }
}