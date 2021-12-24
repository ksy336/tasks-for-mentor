using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace font_adjustment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var style = new FontStyle();
            byte str;
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.WriteLine("Параметры надписи: " + style);
                Console.WriteLine("Введите: ");
                Console.WriteLine("\t 1: bold"); 
                Console.WriteLine("\t 2: italic");
                Console.WriteLine("\t 3: underline");
                if (byte.TryParse(Console.ReadLine(), out str))
                {
                  if( str > 3)
                    {
                        Console.WriteLine("Некорректные данные");
                        continue;
                    }
                    if (style.HasFlag((FontStyle)Math.Pow(2, str - 1)))
                        style ^= (FontStyle)Math.Pow(2, str - 1);
                    else
                        style ^= (FontStyle)Math.Pow(2, str - 1);
                }
            } while (str != 0);





        }
        [Flags]
        public enum FontStyle: byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
    }
}
