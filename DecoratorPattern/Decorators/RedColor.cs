using DecoratorPattern.Shape;

namespace DecoratorPattern.Decorator
{
    public class RedColor : ColorDecorator
    {
        IShape shape;
        public RedColor(IShape shape) : base(shape)
        {
            this.shape = shape;
        }

        public override void Draw() 
        {
            shape.Draw();
            System.Console.WriteLine("with Red color");            
        }
    }
}