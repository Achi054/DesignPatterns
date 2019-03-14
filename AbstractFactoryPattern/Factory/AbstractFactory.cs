using AbstractFactoryPattern.Color;
using AbstractFactoryPattern.Shapes;
using AbstractFactoryPattern.Types;

namespace AbstractFactoryPattern.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetInstance(ShapeType type);
        public abstract IColor GetInstance(ColorType type);
    }
}