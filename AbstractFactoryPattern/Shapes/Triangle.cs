namespace AbstractFactoryPattern.Shapes
{
    public class Triangle : IShape
    {        
        public void draw()
        {
            System.Console.WriteLine("Triangle is drawn");;
        }
    }
}