using System;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Types;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.Shape:
                        return new ShapeFactory();
                case FactoryType.Color:
                        return new ColorFactory();
                default:
                    throw new Exception("Invalid type");
            }
        }
    }
}