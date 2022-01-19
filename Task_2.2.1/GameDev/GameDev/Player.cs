using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    public class Player:  Interfaces.IBody
    {

        public Position position { get; set; }

        #region IBody

        public int Health { get; private set; } = 100;
        public int Weight { get; private set; } = 10;
        public int Strength { get; private set; } = 100;

        public void SetHealth(int i )
        {
            Health += i;
            if( Health < 0 )
            {
                Health = 0;
            }
             if(Health > 100 )
            {
                Health = 100;
            }
        }
        public void SetStrength(int i)
        {
            Strength += i;
            if(Strength < 0 )
            {
                Strength = 0;
            }
            if(Strength > 100)
            {
                Strength = 100;
            }
        }

        public void GetDamage(int DamageValue)
        {
            Health -= DamageValue;
            if(Health < 0)
            {
                Health = 0;
            }
            if(Health > 100)
            {
                Health = 100;
            }
        }


        #endregion

        public void Move(Vector vector, Position newCoordinates)

        {
            try
            {
                position = newCoordinates;
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}

