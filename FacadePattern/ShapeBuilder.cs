using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class ShapeBuilder
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeBuilder()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }
    }
    
}
