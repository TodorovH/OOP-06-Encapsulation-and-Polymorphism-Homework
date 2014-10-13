using System;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Width
        { 
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width cannot be negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be negative.");
                }
                this.height = value;
            }
        }

        public BasicShape (double width)
        {
            this.Width = width;
        }

        public BasicShape (double width, double height) : this(width)
        {
            this.Height = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
