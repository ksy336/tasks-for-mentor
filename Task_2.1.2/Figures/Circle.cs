using System;
using System.Drawing;
using System.Text;

    namespace Custom_Paint
    {
        public class Circle : Figure
        {
            private double center;
            private double radius;
            private const double pi = Math.PI;

            public double Radius { get => radius; set => radius = value; }

            public double Center { get => center; set => center = value; }

            public Circle(double x, double y, double radius)
            {
                Center = new Point(x, y);
                Radius = radius;
            }

            public Circle(double center, double r)
            {
                Center = center;
               
                Radius = r;
            }

            public override double GetLength()
            {
                double length = 2 * pi * radius;
                return length;
            }

            public override double GetArea()
            {
                double square = pi * (radius * radius);
                return square;
            }
            
            public override string ToString()
            {
                return $"Circle: (Center: {Center}; Radius: {Radius})";
            }

        }
    }
}
