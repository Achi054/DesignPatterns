namespace FactoryPattern.ConcreteShapes
{
    public class Circle : IShape
    {
        public void draw()
        {
            System.Console.WriteLine("A circle is drawn");
        }
    }
}