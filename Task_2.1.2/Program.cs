using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Paint
{
     public class Circle
    {
        public double x;
        public double y;
        public double radius;
        public const double pi = Math.PI;

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
}
