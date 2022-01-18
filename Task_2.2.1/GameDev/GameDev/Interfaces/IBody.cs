using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Interfaces
{
    public interface IBody
    {
        int Health { get; }
        int Strength { get; }
        int Weight { get; }

        void SetHealth(int i);
        void SetStrength(int i);
        void GetDamage(int i);
    }
}
