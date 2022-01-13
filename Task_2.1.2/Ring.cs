using System;
using System.Drawing;
using System.Text;

namespace Custom_Paint
{
    public class Ring : Figure
    {
        private double x;
        private double y;
        private double internalRadius;
        private double externalRadius;
        private const double pi = Math.PI;
        public double Radius { get => internalRadius; set => internalRadius = value; }
        public double Radius2 { get => externalRadius; set => externalRadius = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Ring(double x, double y, double externalRadius, double internalRadius) :
           {
            this.x = x;
            this.y = y;
            this.externalRadius = externalRadius;
            this.internalRadius = internalRadius;
        }
        public override double GetArea()
        {
            double square = pi * ((externalRadius * externalRadius) - (internalRadius * internalRadius));
            return square;
        }

        public override double GetLength()
        {
            double length = (2 * pi * externalRadius) + (2 * pi * internalRadius);
            return length;
        }

    }
}