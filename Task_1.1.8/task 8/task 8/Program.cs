using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[3, 3 ,3];
            Random random = new Random();

            for(int i = 0; i < arr.GetLength(0);i++)
            {
                Console.WriteLine("Page № :" + (i + 1));

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = random.Next(-50, 50);

                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                            
                        }
                        Console.Write(arr[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
           
          
        }
    }
}
