using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Paint
{
     public class Circle
    {
        private double x;
        private double y;
        private double radius;
        private const double pi = Math.PI;

        public double Radius { get ; set; }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Circle(double x, double y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }
        public double GetCircle()
        {
            double length = 2 * pi * radius;
            return length;
        }
        public double GetSquare()
        {
            double square = pi * (radius * radius);
            return square;
        }


    }

    public class Ring
    {
        private double centerX;
        private double centerY;
        private double r;
        private double R;
        private const double pi = Math.PI;
        public double Radius { get => r; set => r = value; }
        public double Radius2 { get => R; set => R = value; }
        public double X { get => centerX; set => centerX = value; }
        public double Y { get => centerY; set => centerY = value; }
        public Ring(double x, double y, double r)
        {
            X = x;
            Y = y;
            r = r;
            R = r;
        }

        public double GetSquare()
        {
            double square = pi * ((R * R) - (r * r));
            return square;
        }

        public double GetSumOfLength()
        {
            double length = (2 * pi * R) + (2 * pi * r);
            return length;
        }

    }

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
        public Point(double x , double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        private double length;
        public Point Start {get => Start; set => Start = value;}
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
