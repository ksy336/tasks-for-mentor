using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
   
        public class StringAsCharArray
        {
            private char[] _myString;

            public StringAsCharArray(char[] myString)
            {
                _myString = myString;
            
            }
            public bool IsDifferentOrEquals(char[] firstString, char[] otherString)
            {
                if (firstString.Length != otherString.Length)
                return false;
                for(int i = 0; i < firstString.Length; i++)
                 {
                    if(firstString[i] != otherString[i]) 
                        return false;
                 }
                return true;
            }


            public char[] ConcatStrings(char c)
            {
            var res = new char[_myString.Length + 1];
            _myString.CopyTo(res, 0);
            res[res.Length - 1] = c;
            return res;
            }
            
            public char[] ConcatStrings(StringAsCharArray secondString)
            {
            var res = new char[_myString.Length + secondString._myString.Length];
            _myString.CopyTo(res, 0);
            secondString._myString.CopyTo(res, _myString.Length);
            return res;
           
            }
            
            public int SearchSymbol(char c)
            {
             for(int i = 0; i < _myString.Length; i++)
                {
                    if (c == _myString[i])
                    return i;
                 }
                return -1;
            }

            public char[] ToCharArray()
            {
            var arr = new char[_myString.Length];
            for(int i = 0; i < arr.Length;i++)
            {
                arr[i] = _myString[i];
            }

            return arr;
            }
            public override string ToString()
            {
                return new string(_myString);
            }

            public static double ToDouble(StringAsCharArray convertString)
            {
                var result = Convert.ToDouble(convertString.ToString());
                return result;
            } 

            public char this[int index]
            {
                get => _myString[index];
                set => _myString[index] = value; 
            }



         }

       class Program
    {
        static void Main(string[]args)
        {
            var exampleString = new char[11] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'j', 'a', 'v', 'a' };
            var otherExample = new char[1] { 'l' };

            StringAsCharArray firstString = new StringAsCharArray(exampleString);
            StringAsCharArray secondString = new StringAsCharArray(otherExample);
            StringAsCharArray concatStrings = new StringAsCharArray(firstString.ConcatStrings(secondString));
            

            Console.WriteLine(concatStrings.ToString());
            Console.WriteLine(firstString[5]);

        }
    }
        
    
}
