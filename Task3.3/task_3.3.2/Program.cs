using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public static class SuperString
    {
        public enum DifferentLanguagues
        {
            English,
            Russian,
            Number,
            Mixed
        }
        static DifferentLanguagues SetLanguage (this string usefulString)
        {
            char[] usefulstring = usefulString.ToCharArray();

            if (usefulString.All(c => (c >= 'а' && c <= 'я' && c == 'ё') || (c >= 'А' && c <= 'Я' && c == 'Ё')))
            {
                return DifferentLanguagues.Russian;

            } else if (usefulString.All(c => (c >= 'a' && c <= 'z' ) || (c >= 'A' && c <= 'Z'))) {
                return DifferentLanguagues.English;

            } else if (usefulString.All(c => char.IsDigit(c))) {

                return DifferentLanguagues.Number;
            } else
            {
                return DifferentLanguagues.Mixed;
            }
        }
    }
}
