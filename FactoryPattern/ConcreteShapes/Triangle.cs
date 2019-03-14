namespace FactoryPattern.ConcreteShapes
{
    public class Triangle : IShape
    {
        public void draw()
        {
            System.Console.WriteLine("A triangle is drawn");
        }
    }
}