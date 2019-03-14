using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CannotSwim : ISwimBehaviour
    {
        public void Swim()
        {
            System.Console.WriteLine("Cannot swim like a duck.");
        }
    }
}