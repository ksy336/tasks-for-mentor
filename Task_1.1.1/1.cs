using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            bool repeatCycle = true;

            while(repeatCycle)
            {
                do
                {
                    Console.Write("A = ");
                }
                while (!int.TryParse(Console.ReadLine(), out a)); 
                    do
                    {
                        Console.Write("B = ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out b));
                        if(a <= 0 || b <= 0)
                    {
                        Console.WriteLine("Введены неверные данные. Попробуйте еще раз. Y/N ");
                        var ki = Console.ReadKey(true);
                        if(ki.Key != ConsoleKey.Y)
                        {
                            repeatCycle = false;
                        }
                        continue;
                    }
                Console.WriteLine(" Длина: {0}, Ширина: {1}, Площадь: {2} " , a, b, a * b);
                repeatCycle = false;
                Console.ReadKey();

            }
        }
    }
}
 