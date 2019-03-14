namespace FacadePattern.Models
{
    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Square is drawn.");
        }
    }
}