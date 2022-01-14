using System;
using System.Drawing;
using System.Text;

namespace Custom_Paint
{
    class Square : Figure
    {
        public double Left { get => left; set => left = value; }

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

        public override string ToString()
        {
            return $"Square: (Side1:{Left}; Side2{Left}; Side3{Left}; Side4{Left};)";
        }
    }
}