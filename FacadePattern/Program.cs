using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Pattern");

            var facade = new ShapeFacade();

            facade.DrawCircle();
            facade.DrawSquare();
            facade.DrawTriangle();

            Console.ReadLine();
        }
    }
}
