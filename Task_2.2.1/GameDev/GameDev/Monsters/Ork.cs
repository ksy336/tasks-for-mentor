using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Monsters
{
    public class Ork : Monster, Interfaces.IBody
    {
        public Ork() 
        {
            MonstersHealth = 30;
            MonstersStrength = 25;
            MonstersWeight = 30;

        }


        public override int DamageValue => 15;

        public Position position { get; private set; }

        public override void Move(Position newCoordinates) 
        {
            position = newCoordinates;
        }
       
    }
}
