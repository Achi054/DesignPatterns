using DecoratorPattern.Shape;

namespace DecoratorPattern.Decorator
{
    public class BlueColor : ColorDecorator
    {
        IShape shape;
        public BlueColor(IShape shape) : base(shape)
        {
            this.shape = shape;
        }

        public override void Draw()
        {
            shape.Draw();
            System.Console.WriteLine("with Blue color");
        }
    }
}