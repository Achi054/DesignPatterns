namespace FactoryPattern.ConcreteShapes
{
    public class Square : IShape
    {
        public void draw()
        {
            System.Console.WriteLine("A square is drawn");
        }
    }
}