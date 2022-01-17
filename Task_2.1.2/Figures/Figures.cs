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

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}; {Y})";
        }
    }

    public class Circle : Figure
    {
       
        private double _radius;
        
        private const double pi = Math.PI;

        public double Radius { get => _radius; set => _radius = value; }

        public Point Center { get; }

        public Circle(Point point, double radius)
        {
            Center = point;

            Radius = radius;
        }

        public Circle(double x, double y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

        public override double GetLength()
        {
           return 2 * pi * Radius;
        }
        public override double GetArea()
        {
            return pi * (Radius * Radius);
        }
        public override string ToString()
        {
            return $"Circle: (Center: {Center}; Radius: {Radius})";
        }

    }

    public class Line : Figure
    {
        private double length;
        public Point Start { get; set; }
        public Point End { get; set; }
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
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point4;

        public double Width { get => Width; set => Width = value; }
        public double Height { get => Height; set => Height = value; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
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
        public Point Point1 { get; }

        public Ring(double x, double y, double externalRadius, double internalRadius)
           {
            this.x = x;
            this.y = y;
            this.externalRadius = externalRadius;
            this.internalRadius = internalRadius;
        }

        public Ring(Point point1, double internalRadius, double externalRadius)
        {
            Point1 = point1;
            this.internalRadius = internalRadius;
            this.externalRadius = externalRadius;
        }

        public override double GetArea()
        {
            double square = pi * ((Radius2 * Radius2) - (Radius * Radius));
            return square;
        }

        public override double GetLength()
        {
            double length = (2 * pi * Radius2) + (2 * pi * Radius);
            return length;
        }

        public override string ToString()
        {
            return $"Ring: (Internal radius: {Radius}; External radius:{Radius2})";
        }

    }

    class Square : Figure
    {
        private double left;
        public double Left { get => left; set => left = value; }
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }
        public Point Point4 { get; }

        public Square(double a)
        {
            Left = a;
        }

        public Square(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
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
        private Point point1;
        private Point point2;
        private Point point3;

      /*  public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
*/
        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
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
