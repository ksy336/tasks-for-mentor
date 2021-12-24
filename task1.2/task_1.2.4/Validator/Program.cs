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
            string newString = "";
            var array = str.ToCharArray();
            newString += Char.ToUpper(array[0]).ToString();
            newString += array[1].ToString();
            

            for(int i = 2; i < array.Length; i++)
            {
                if (IsRightSymbol(array[i - 2]) && Char.IsLetter(array[i]))
                {
                    newString += Char.ToUpper(array[i]).ToString();
                } else
                {
                    newString += array[i].ToString();
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
