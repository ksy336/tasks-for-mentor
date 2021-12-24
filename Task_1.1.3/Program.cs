using System;


namespace ConsoleApp3
{
     class Program
    {
        static void Main(string[] args)
        {
           
       
            int height;
            string str;
            do
            {
                Console.WriteLine("Введите высоту равнобедренного треугольника: ");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out height));
            Console.Clear();


            int spaces;
            int symbols;

            for (int i = height; i > 0; i--)
            {
                symbols = 2 * height - 2 * i + 1;
                spaces = i;
                while (spaces >= 0)
                {
                    Console.Write(" ");
                    spaces--;
                }
                while (symbols > 0)
                {
                    Console.Write("*");
                    if (symbols == 1)
                        Console.WriteLine();
                    symbols--;
                    
                }
            }
        }
       
      
    }
}
