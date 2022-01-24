using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    public class Vector
    {
        public Vector() { }
        public Point Coordinates { get; private set; }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator *(Vector v1, int i)
        {
            return new Vector { X = (v1.X * i), Y = (v1.Y * i) };
        }
    }
}
