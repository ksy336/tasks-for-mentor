using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        public virtual double GetLength() { 
            return 0;
        }
        public virtual double GetArea()
        {
            return 0;
        }
    }

    public class Point : Figure
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

    public class Circle : Figure
    {
        private double center;
        private double radius;
        private Point point1;
        private double internalRadius;
        private const double pi = Math.PI;

        public double Radius { get ; }

        public Point Center { get; }

        public Circle(Point center, double radius)
        {
            Center = center;

            Radius = radius;
        }

        public Circle(int x, int y, double radius) : this(new Point(x, y), radius) { }

        public override double GetLength()
        {
           return 2 * pi * radius;
        }
        public override double GetArea()
        {
            return pi * (radius * radius);
        }
        public override string ToString()
        {
            return $"Circle: (Center: {Center}; Radius: {Radius})";
        }

    }

    public class Line : Figure
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
            
        }

        public override double GetLength()
        {
            return SetLength(Start, End);
        }
        public static double SetLength(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2));
        }

        public double Length
        {
            get => length;
        }

        public override string ToString()
        {
            return $"(Start: {Start}; End:{End})";
        }

    }

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
            return Width* Height;
        }

        public override string ToString()
        {
            return $"(Rectangle: (Width:{Width}; Height:{Height})";
        }
    }

    public class Ring : Figure
    {
        private double internalRadius;
        private double externalRadius;
        private double x;
        private double y;
        private const double pi = Math.PI;
        public double Radius { get => internalRadius; set => internalRadius = value; }
        public double Radius2 { get => externalRadius; set => externalRadius = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Ring(double x, double y, double externalRadius, double internalRadius)
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

        public override string ToString()
        {
            return $"Ring: (Internal radius: {internalRadius}; External radius:{externalRadius})";
        }

    }

    class Square : Figure
    {
        private double left;
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
