using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CanSwim : ISwimBehaviour
    {
        public void Swim()
        {
            System.Console.WriteLine("Can swim like a duck.");
        }
    }
}