using System;
using System.Drawing;
using System.Text;

namespace Custom_Paint
{
    class Triangle : Figure
    {
        private double AB;
        private double BC;
        private double AC;
        private double A;
        private double B;
        private double C;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetLength()
        {
            return AB + AC + BC;
        }
        public override double GetArea()
        {
            double p = (AB + AC + BC) / 2;
            return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
        }

        public override string ToString()
        {
            return $"Triangle: (FirstSide: {AB}; SecondSide: {AC}; ThirdSide:{BC};)";
        }
    }

}