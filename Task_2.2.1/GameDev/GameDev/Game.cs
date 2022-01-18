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
        private GameField gameField;
        private Player player;
        private GameController gameController = new GameController();
        private List<Obstacle> obstacles = new List<Obstacle>(2);
        private List<Monster> monsters = new List<Monster>(2);
        private List<Bonus> bonuses = new List<Bonus>(2);

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
            Console.WriteLine($"Здоровье игрока: {player.Health}");
            Console.WriteLine($"Сила игрока: {player.Strength}");
            Console.WriteLine($"Игрок находится сейчас на позиции: {player.Point}");
        }
    }
}
