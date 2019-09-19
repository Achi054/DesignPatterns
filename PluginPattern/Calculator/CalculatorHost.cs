namespace Calculator
{
    public class CalculatorHost
    {
        public CalculatorHost(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        private int x, y;
        private ICalculator calculator;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Calculate()
        {
            return calculator.Calculate(x, y);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} = {3}",
                 x.ToString(),
                 calculator.GetSymbol(),
                 y.ToString(),
                 calculator.Calculate(x, y));
        }
    }
}
