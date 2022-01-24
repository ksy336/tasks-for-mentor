﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите текст:");
                string text = Console.ReadLine().ToUpper();
                char[] chars = new char[] { ' ', ',', '.', '?', '!', '-', '"' };
                string[] result = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> textDictionary = new Dictionary<string, int>();
                textDictionary.FirstOrDefault(res => res.Key == result[0]);
                for (int obj = 0; obj < result.Length; obj++)
                {
                    if (textDictionary.ContainsKey(result[obj]))
                    {
                        textDictionary[result[obj]]++;
                    } else
                    {
                        textDictionary.Add(result[obj], 1);
                    }
                }
                foreach (var element in textDictionary)
                {
                    Console.WriteLine($"Данное слово {element.Key} встречается {element.Value} раз.");

                }
                if (textDictionary.Where(el => el.Value > 3).Count() < textDictionary.Count() * 0.2)
                {
                Console.WriteLine("Все хорошо. Текст можно не испралять.");
                }
            else
                {
                Console.WriteLine("повторений нашлось много. Попробуй исправить текст.");

                }
        }
    }
}
