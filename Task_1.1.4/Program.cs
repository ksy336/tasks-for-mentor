using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string str;
            do
            {
                Console.WriteLine("Введите число: ");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out n));
            Console.Clear();


            for (int i = 0; i <= n; i++)
            {
                for (
                    var j = 0; j <= i; j++)
                {
                    var branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(n) + "*" + branch);
                }
            }
        }
    }
}
