using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class SuperArray
    {
        public static void ExpendArray<T>(this T[] elements, Action<T> action)
        {
            foreach(var element in elements)
            {
                action(element);
            }
        }

        public static int GetSum(this int[] elements)
        {
            int sum = 0;
            foreach(var element in elements)
            {
                sum += element;
            }

            return sum;
        }

        public static int GetAverageNumber(this int[] elements)
        {
            int averageNumber = elements.GetSum() / elements.Length;

            return averageNumber;
        }

        public static int GetConstantlyRepeatedElement(int[] elements)
        {
            int length = elements.Length;
            bool moreThanOneMaximum = false;
            int maxCount = -1;
            int maxNumber = -1;
            Dictionary<int, int> counts = new Dictionary<int, int>(length);

            for(int index = 0; index < length; ++index)
            {
                int current = elements[index];
                if(counts.ContainsKey(current))
                {
                    counts[current]++;
                } else
                {
                    counts.Add(current, 1);
                }
            }
           
            foreach(var pair in counts)
            {
                if(pair.Value > maxCount)
                {
                    maxNumber = pair.Key;
                    maxCount = pair.Value;
                    moreThanOneMaximum = false;
                } else if(pair.Value == maxCount)
                {
                    moreThanOneMaximum = true;
                }
            }
            return (moreThanOneMaximum) ? 0 : maxNumber;
             
        }
        
    }
}
