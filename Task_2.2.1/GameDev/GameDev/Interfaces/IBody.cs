using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Interfaces
{
    public interface IBody
    {
        int Health { get; set; }
        int Strength { get; set; }
        int Weight { get; }

        void GetDamage(int i);
    }
}
