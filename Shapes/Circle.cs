using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public double Radius 
        { 
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius cannot be negative.");
                }
                this.radius = value;
            }
        }

        public Circle (double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
