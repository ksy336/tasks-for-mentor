using System;
using System.Drawing;
using System.Text;

namespace Custom_Paint
{
    class Square : Figure
    {
        public double Left { get => Left; set => Left = value; }

        public Square(double a)
        {
            Left = a;
        }

        public override double GetLength()
        {
            return Left * 4;
        }
        public override double GetArea()
        {
            return Left * Left;
        }
    }
}