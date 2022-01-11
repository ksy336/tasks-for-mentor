using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");

            string str;
            str = Console.ReadLine();
            string[] word = str.Split(new char[] { ' ', ',', ':', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Array: {string.Join(",", word)}");
            int allWordsLength = 0;
            foreach (string s in word)
            {
                allWordsLength += s.Length;
            }

            int averageLength = allWordsLength / word.Length;
             Console.WriteLine($"Средняя длина слова в данной строке: {averageLength}");
        }
      
    }
}
