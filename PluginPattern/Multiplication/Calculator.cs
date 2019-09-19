using System;
using Calculator;

namespace Multiplication
{
    [CalculationPlugIn("Plugin to multipy 2 numbers")]
    public class Calculator : ICalculator
    {
        public int Calculate(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public char GetSymbol()
        {
            return 'x';
        }
    }
}
