using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Obstacles
{
    public abstract class Obstacle
    {
        private int[] Size;

        protected Obstacle(int[] size)
        {
            Size = size;
        }
    }
}
