using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShapeBuilder shapeBuilder = new ShapeBuilder();

            shapeBuilder.DrawCircle();
            shapeBuilder.DrawRectangle();
            shapeBuilder.DrawSquare();

            Console.ReadKey();
        }
    }
}
