using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CanQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Can quacks like a duck.");
        }
    }
}