using FactoryPattern.ConcreteShapes;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static IShape GetInstance(ShapeType type)
        {
            IShape instance;
            switch (type)
            {
                case ShapeType.Circle: instance = new Circle();
                                    break;
                case ShapeType.Square: instance = new Square();
                                    break;
                case ShapeType.Triangle: instance = new Triangle();
                                    break;
                default:
                    instance = new Circle();
                    break;
            }
            return instance;
        }
    }
}