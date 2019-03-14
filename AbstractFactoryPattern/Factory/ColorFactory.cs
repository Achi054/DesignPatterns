using System;
using AbstractFactoryPattern.Color;
using AbstractFactoryPattern.Shapes;
using AbstractFactoryPattern.Types;

namespace AbstractFactoryPattern.Factory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetInstance(ColorType type){
            switch (type)
            {
                case ColorType.Red:
                    return new Red();
                case ColorType.Green:
                    return new Green();
                case ColorType.Blue:
                    return new Blue();
                default:
                    throw new Exception("Invalid type");
            }
        }

        public override IShape GetInstance(ShapeType type)
        {
            throw new NotImplementedException();            
        }
    }
}