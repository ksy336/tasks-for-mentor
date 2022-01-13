using System;
using System.Drawing;
using System.Text;

namespace Figures
{
    public class Point
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double a)
        {
            X = a;
            Y = a;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}