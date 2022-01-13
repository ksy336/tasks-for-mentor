using System;
using System.Drawing;
using System.Text;

namespace Figures
{
    using System;
    using System.Drawing;
    using System.Text;

    namespace Figures
    {
        public class Circle : Figure
        {
            private double centerX;
            private double centerY;
            private double radius;
            private const double pi = Math.PI;

            public double Radius { get; set; }

            public double X { get => centerX; set => centerX = value; }
            public double Y { get => centerY; set => centerY = value; }
            public Circle(double x, double y, double r)
            {
                X = x;
                Y = y;
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


        }
    }
}
