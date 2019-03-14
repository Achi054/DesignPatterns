using System;
using AbstractFactoryPattern.Types;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstarct Factory Pattern");

            var shapeFactory = FactoryProducer.GetFactory(FactoryType.Shape);
            var circle = shapeFactory.GetInstance(ShapeType.Circle);
            var square = shapeFactory.GetInstance(ShapeType.Square);
            var triangle = shapeFactory.GetInstance(ShapeType.Triangle);

            circle.draw();
            square.draw();
            triangle.draw();

            var colorFactory = FactoryProducer.GetFactory(FactoryType.Color);
            var red = colorFactory.GetInstance(ColorType.Red);
            var blue = colorFactory.GetInstance(ColorType.Blue);
            var green = colorFactory.GetInstance(ColorType.Green);

            red.draw();
            blue.draw();
            green.draw();

            Console.ReadLine();
        }
    }
}
