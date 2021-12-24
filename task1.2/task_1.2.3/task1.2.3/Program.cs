using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str;
            str = Console.ReadLine();
            string[] words = str.Split(new char[] {' ', ',', '!', '.', ':', ';'}, StringSplitOptions.RemoveEmptyEntries);
            int amountOfWords = 0;
            List<string> list = new List<string>();

            foreach (string element in words)
            {
                if (Char.IsLower(element[0]))
                {
                  
                    list.Add(element);
                    string[] onlyLowerwords = list.ToArray();
                    amountOfWords = onlyLowerwords.Length;
                }
            }
            Console.WriteLine($"Количество слов, начинающихся с маленькой буквы: {amountOfWords}");

        }
    }
}
