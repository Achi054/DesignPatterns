using StrategyPattern.StrategyInterface;

namespace StrategyPattern.ConcreteStrategies
{
    public class CanFly : IFlyBehaviour
    {
        public void Fly()
        {
            System.Console.WriteLine("Can fly by flapping wings.");
        }
    }
}