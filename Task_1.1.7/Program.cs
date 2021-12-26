using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int[] arr = new int[10];
            
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            
                arr[i] = rand.Next(0, 20);

                Console.WriteLine($"Array = {string.Join(",", arr)}");
          
            
            GetMaxValue(arr);
            GetMinValue(arr);
            GetSortedArray(arr);
        }
        public static void GetMaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i])
                    max = arr[i];

                    Console.WriteLine($"Max: {max}");
            
        }
        public static void GetMinValue(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i])
                    min = arr[i];
            Console.WriteLine($"Min: {min}");
        }
        public static int[] GetSortedArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
              
            }
            Console.WriteLine($"Array = {string.Join(",", arr)}");
            return arr;
        }
    }
}
