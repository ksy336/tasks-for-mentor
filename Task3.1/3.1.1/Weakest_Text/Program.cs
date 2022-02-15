using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> people = new List<object>();
          
            while (true)
            {
                Console.WriteLine("Введите Число: ");
                bool N = int.TryParse(Console.ReadLine(), out int n);
                if(!N)
                {
                    Console.WriteLine("Введите число: ");

                }
                for(int obj = 0; obj < n;obj++)
                {
                    object person = new Object();
                    people.Add(person);
                }
                Console.WriteLine(": Сгенерирован круг людей. Начинаем вычеркивать каждого второго");
                CheckedOut(people);
            }
        }

        public static void CheckedOut(List<object> people)
        {
            int count = 1;
            for (int i = 1; i < people.Count; i++)
            {
                people.RemoveAt(i);
                Console.WriteLine($"Раунд {count++}.Вычеркнут человек. Людей осталось: {people.Count}");
                if(people.Count % 2 == 0)
                {
                    i = -1;
                } else
                {
                    i = 0;
                }
                if(people.Count == 1)
                {
                    Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    Environment.Exit(0);                
                        
                }
            }
        }



    }
}
