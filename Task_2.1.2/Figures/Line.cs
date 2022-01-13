using System;
using System.Drawing;
using System.Text;

namespace Figures
{
    class Line : Figure
    {
        private double length;
        public Point Start { get => Start; set => Start = value; }
        public Point End { get => End; set => End = value; }
        public Line()
        {
        }
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
            GetLength(start, end);
        }

        public void GetLength(Point start, Point end)
        {
            length = Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2));
        }

        public double Length
        {
            get => length;
        }

    }
}