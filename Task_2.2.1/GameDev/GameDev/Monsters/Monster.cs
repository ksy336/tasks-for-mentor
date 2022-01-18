using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Monsters
{
    public abstract class Monster: Interfaces.IBody, Interfaces.IMovable
    {
        protected int MonstersHealth = 20;
        protected int MonstersWeight = 20;
        protected int MonstersStrength = 20;
        public abstract int DamageValue { get; }

        #region IBody

        public int Health => MonstersHealth;
        public int Weight => MonstersWeight;
        public int Strength => MonstersStrength;

        public void SetHealth(int i)
        {
            MonstersHealth += i;

            if(MonstersHealth < 0)
            {
                MonstersHealth = 0;
            }

            if(MonstersHealth > 100)
            {
                MonstersHealth = 100;
            }
               
        }

        public void SetStrength(int i)
        {
            MonstersStrength -= i;

            if(MonstersStrength < 0)
            {
                MonstersStrength = 0;
            }
        }

        public void GetDamage(int i)
        {
            MonstersHealth -= i;
            if(MonstersHealth < 0)
            {
                MonstersHealth = 0;
            }
            if(MonstersHealth > 100)
            {
                MonstersHealth = 100;
            }
        }
        #endregion

        #region IMovable

        public Point Point { get; protected set; }

        public void Move(Vector v, Material m)
        {
            if(m.IsMovable(this))
            {
                Point +=  v;
            }
        }
        #endregion

        public virtual void Attack(Player player)
        {
            player.GetDamage(DamageValue);
        }


    }
}
