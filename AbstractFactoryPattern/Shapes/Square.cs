namespace AbstractFactoryPattern.Shapes
{
    public class Square : IShape
    {        
        public void draw()
        {
            System.Console.WriteLine("Square is drawn");;
        }
    }
}