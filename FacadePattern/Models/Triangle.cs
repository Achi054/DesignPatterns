namespace FacadePattern.Models
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Triangle is drawn.");
        }
    }
}