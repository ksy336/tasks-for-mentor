﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(20, 40);
            game.MoveController(Console.ReadKey().Key);
        }
    }
}
