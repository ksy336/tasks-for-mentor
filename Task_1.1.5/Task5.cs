using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 1000;
            int sum = 0;

            
            for(int i = n; i < m; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine(sum);
                }
               

            }
        }
    }
}
