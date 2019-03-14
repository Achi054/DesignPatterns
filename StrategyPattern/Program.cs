using System;
using StrategyPattern.ConcreteStrategies;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern");

            var rubberDuck = new Duck(new CannotFly(), new CannotQuack(), new CannotSwim());
            var muteDuck = new Duck(new CanFly(), new CannotQuack(), new CanSwim());
            var disabledDuck = new Duck(new CannotFly(), new CanQuack(), new CannotSwim());

            System.Console.WriteLine("Rubber duck behaviour.");
            rubberDuck.Fly();
            rubberDuck.Swim();
            rubberDuck.Quack();

            System.Console.WriteLine("Mute duck behaviour.");
            muteDuck.Fly();
            muteDuck.Swim();
            muteDuck.Quack();

            System.Console.WriteLine("Disabled duck behaviour.");
            disabledDuck.Fly();
            disabledDuck.Swim();
            disabledDuck.Quack();

            Console.ReadLine();
        }
    }
}
