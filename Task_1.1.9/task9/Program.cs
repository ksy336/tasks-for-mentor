using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 100);   
                   
            }
            Console.WriteLine($"Array: {string.Join(",", arr)}");
            GetSum(arr);

        }
        static void GetSum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                if(arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
