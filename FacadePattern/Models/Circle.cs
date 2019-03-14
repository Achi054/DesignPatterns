namespace FacadePattern.Models
{
    public class Circle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Circle is drawn.");
        }
    }
}