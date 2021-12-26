using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            string str = "";
            do
            {
                Console.WriteLine("Введите любое число: ");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out h));
            Console.Clear();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}