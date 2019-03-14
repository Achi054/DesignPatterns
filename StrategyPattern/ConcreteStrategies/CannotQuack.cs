using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CannotQuack : IQuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("Cannot quacks like a duck.");
        }
    }
}