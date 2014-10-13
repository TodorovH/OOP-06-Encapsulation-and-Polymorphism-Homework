using System;

namespace Shapes
{
    public class Triangle : BasicShape
    {
        private double secondSide;
        private double thirdSide;

        public Triangle (double width, double secondSide, double thirdSide) : base(width)
        {
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public double SecondSide
        {
            get
            {
                return this.secondSide;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The second side cannot be negative.");
                }
                this.secondSide = value;
            }
        }

        public double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The third side cannot be negative.");
                }
                this.thirdSide = value;
            }
        }


        bool isTriangle = false;
        public void CanCreateTriangle(double width, double secondSide, double thirdSide)
        {
            if ((this.Width + this.SecondSide) > this.ThirdSide && (this.Width + this.ThirdSide) > this.SecondSide && (this.ThirdSide + this.SecondSide) > this.Width)
            {
                isTriangle = true;
            }
        }

        public override double CalculateArea()
        {
            CanCreateTriangle(this.Width, this.SecondSide, this.ThirdSide);
            double p = 0;
            double area = 0;
            if (isTriangle == true)
            {
                p = (this.Width + this.SecondSide + this.ThirdSide) / 2;
                area = Math.Sqrt(p * (p - this.Width) * (p - this.SecondSide) * (p - this.ThirdSide));
            }
            else
            {
                throw new ArithmeticException("The sides cannot create triangle.");
            }
            return area; ;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 0;
            if (isTriangle == true)
            {
                perimeter = this.Width + this.SecondSide + this.ThirdSide;
            }
            else
            {
                throw new ArithmeticException("The sides cannot create triangle.");
            }
            return perimeter;
        }
    }
}
