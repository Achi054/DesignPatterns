using DecoratorPattern.Shape;

namespace DecoratorPattern.Decorator
{
    public abstract class ColorDecorator : IShape
    {
        IShape shape;

        public ColorDecorator(IShape shape)
        {
            this.shape = shape;
        }

        public abstract void Draw();
    }    
}