using GameDev.Bonuses;
using GameDev.Monsters;
using GameDev.Obstacles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    public class Game
    {
        private Player player;
        private GameController controller = new GameController();
        private List<Obstacle> obstacles = new List<Obstacle>(2);
        private List<Monster> monsters = new List<Monster>(2);
        private List<Bonus> bonuses = new List<Bonus>(2);
        public Position position { get; protected set; }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public Game(int width, int height)
        {
            Width = width;
            Height = height;

            player = new Player();
        }
        public void MoveController(ConsoleKey cli)
        {
            Vector vector = controller.DoStep(cli);

            if (vector != null)
            {
               
                player.Move();
            }
        }

    }
}
