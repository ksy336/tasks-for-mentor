using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str;
            str = Console.ReadLine();
            StringBuilder newString = new StringBuilder();
            var array = str.ToCharArray();
            newString.Append(Char.ToUpper(array[0]));
            newString.Append(array[1]);
            

            for(int i = 2; i < array.Length; i++)
            {
                if (IsRightSymbol(array[i - 2]) && Char.IsLetter(array[i]))
                {
                    newString.Append(Char.ToUpper(array[i]));
                } else
                {
                    newString.Append(array[i]);
                }
            }
            Console.WriteLine(newString);
           
        }
        static bool IsRightSymbol(char c)
        {
          return   c == '.' || c == '!' || c == '?';
        }
    }
}
