using System;
using System.Drawing;
using System.Text;

namespace Figures
{
    class Rectangle : Figure
    {
        public double Width { get => Width; set => Width = value; }
        public double Height { get => Height; set => Height = value; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetLength()
        {
            return 2 * Width + 2 * Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}