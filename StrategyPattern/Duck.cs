using StrategyPattern.StrategyInterface;

namespace StrategyPattern
{
    public class Duck
    {
        public IFlyBehaviour _flyBehaviour;
        public IQuackBehaviour _quackBehaviour;
        public ISwimBehaviour _swimBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, 
                    IQuackBehaviour quackBehaviour, 
                    ISwimBehaviour swimBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
            _swimBehaviour = swimBehaviour;
        }

        public void Fly()
        {
            _flyBehaviour.Fly();            
        }

        public void Swim()
        {
            _swimBehaviour.Swim();            
        }

        public void Quack()
        {
            _quackBehaviour.Quack();            
        }
    }
}