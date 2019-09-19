using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4, y = 2;

            Console.WriteLine(String.Format("x={0} y={1}", x.ToString(), y.ToString()));

            foreach (CalculatorHost calculator in CalculatorHostProvider.Calculators)
            {
                calculator.X = x;
                calculator.Y = y;
                Console.WriteLine(calculator.ToString());
            }
            Console.ReadLine();
        }
    }
}
