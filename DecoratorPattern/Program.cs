using System;
using DecoratorPattern.Decorator;
using DecoratorPattern.Shape;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern !");

            var circle = new CircleShape();
            var redCircle = new RedColor(circle);

            var square = new SquareShape();
            var blueSquare = new BlueColor(square);

            redCircle.Draw();
            blueSquare.Draw();

            Console.ReadLine();
        }
    }
}
