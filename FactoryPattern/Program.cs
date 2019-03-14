using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern");

            var circle = ShapeFactory.GetInstance(ShapeType.Circle);
            var square = ShapeFactory.GetInstance(ShapeType.Square);
            var triangle = ShapeFactory.GetInstance(ShapeType.Triangle);

            circle.draw();
            square.draw();
            triangle.draw();

            System.Console.ReadLine();
        }
    }
}
