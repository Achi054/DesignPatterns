using System;
using AbstractFactoryPattern.Color;
using AbstractFactoryPattern.Shapes;
using AbstractFactoryPattern.Types;

namespace AbstractFactoryPattern.Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetInstance(ShapeType type){
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    throw new Exception("Invalid type");
            }
        }

        public override IColor GetInstance(ColorType type){
            throw new NotImplementedException();
        }
    }
}