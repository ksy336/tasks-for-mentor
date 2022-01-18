using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Monsters
{
    public  class Zombie: Monster, Interfaces.IBody, Interfaces.IMovable
    {
        public Zombie()
        {
            MonstersHealth = 25;
            MonstersStrength = 15;
            MonstersWeight = 25;
        }

        public override int DamageValue => 12; 

    }
}
