using DecoratorPattern.Shape;

namespace DecoratorPattern.Shape
{
    public class CircleShape : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Circle is drawn");
        }
    }
}