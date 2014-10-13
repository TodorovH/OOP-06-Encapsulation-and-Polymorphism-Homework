using System;
using System.Collections.Generic;

namespace Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            var shapes = new IShape[]
        {
            new Circle(1),
            new Rectangle(2.5, 4),
            new Triangle(3, 4, 5)
        };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + ": ");
                Console.WriteLine("Area: {0:f2}", shape.CalculateArea());
                Console.WriteLine("Perimeter: {0:f2}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
