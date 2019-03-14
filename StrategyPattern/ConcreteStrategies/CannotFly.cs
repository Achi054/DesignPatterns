using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CannotFly : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Cannot fly by flapping wings.");
        }
    }
}