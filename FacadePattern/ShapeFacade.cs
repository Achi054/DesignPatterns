using FacadePattern.Models;

namespace FacadePattern
{
    public class ShapeFacade
    {
        private IShape _circle;
        private IShape _square;
        private IShape _triangle;

        public ShapeFacade()
        {
            _circle = new Circle();
            _square = new Square();
            _triangle = new Triangle();
        }

        public void DrawCircle()
        {
            _circle.Draw();            
        }

        public void DrawSquare()
        {
            _square.Draw();            
        }

        public void DrawTriangle()
        {
            _triangle.Draw();            
        }
    }
}