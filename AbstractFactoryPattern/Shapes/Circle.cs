namespace AbstractFactoryPattern.Shapes
{
    public class Circle : IShape
    {        
        public void draw()
        {
            System.Console.WriteLine("Circle is drawn");;
        }
    }
}