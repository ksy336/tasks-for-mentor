using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            Random random = new Random();
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-10, 50);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            GetSumOfEvenElem(arr);


        }
        static void GetSumOfEvenElem(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
