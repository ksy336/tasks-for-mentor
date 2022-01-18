using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Interfaces
{
    public interface IMovable
    {
        Point Point { get; }
        void Move(Vector v, Material m);
    }
}
