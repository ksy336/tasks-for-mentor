using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст 1: ");
            string input1;
            input1 = Console.ReadLine();
            Console.WriteLine("Введите текст 2: ");
            string input2;
            input2 = Console.ReadLine();
            string output = "";

            foreach(char ch in input1)
            {
                if(!input2.Contains(ch))
                {
                    output += ch;
                } else
                {
                    output += ch;
                    output += ch;
                }
            }
            Console.WriteLine($"Результат: {output}");
        }
    }
}
