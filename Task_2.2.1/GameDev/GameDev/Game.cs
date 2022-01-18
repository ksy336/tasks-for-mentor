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
        private GameField gameField;
        private Player player;
        private GameController gameController = new GameController();
        private List<Obstacle> obstacles = new List<Obstacle>(2);
        private List<Monster> monsters = new List<Monster>(2);

        public int Height { get; private set; }
        public int Width { get; private set; }
        public Game(int width, int height)
        {
            Width = width;
            Height = height;

            player = new Player();
            gameField = new GameField(width, height);
            player.Moving += Player_Moving;
        }

        private void Player_Moving()
        {

        }
    }
}
