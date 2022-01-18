using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    public class GameController
    {
        private Dictionary<ConsoleKey, Vector> moveCommands = new Dictionary<ConsoleKey, Vector>
        {
             { ConsoleKey.UpArrow,    new Vector(0,1)  },
             { ConsoleKey.DownArrow,  new Vector(0,-1) },
             { ConsoleKey.LeftArrow,  new Vector(-1,0) },
             { ConsoleKey.RightArrow, new Vector(1,0)  },
        };

        public Vector DoStep(ConsoleKey cli)
        {
            try
            {
                return moveCommands[cli];
            }

            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
