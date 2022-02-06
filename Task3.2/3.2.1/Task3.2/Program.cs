using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }

    class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        T[] dynamicArray;
        public int Length { get; private set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }

        }
      
        public DynamicArray(IEnumerable<T> listToArray)
        {
            dynamicArray = listToArray.ToArray();
            Length += (from element in dynamicArray select element).Count();
        }
        public DynamicArray()
        {
            dynamicArray = new T[9];
        }

        public DynamicArray(int capacity)
        {
            dynamicArray = new T[capacity];
        }

        void MultipleMaker(int length)
        {
            int result = dynamicArray.Length;

            while (result < length)
            {
                result = result * 2;
            }

            T[] array = new T[result];
            for (int obj = 0; obj < Length; obj++)
            {
                array[obj] = dynamicArray[obj];
            }

            dynamicArray = array;
        }

        void Append(T addObj)
        {
            if (Length == dynamicArray.Length)
            {
                MultipleMaker(++Length);
            }

            dynamicArray.Append<T>(addObj);

        }

        void AppendList(IEnumerable<T> addList)
        {
            int res = addList.Count() + dynamicArray.Length;

            if (Length <= res)
            {
                MultipleMaker(res);
            }

            foreach (var el in addList)
            {
                dynamicArray.Append(el);
            }
        }

        bool AppendElement(int insertObjIndex, T appendedObj)
        {
            if (Length == dynamicArray.Length)
            {
                MultipleMaker(++Length);
            }
            for (int i = Length; i >= insertObjIndex; i--)
            {
                dynamicArray[i + 1] = dynamicArray[i];
            }
            Length++;
            dynamicArray[insertObjIndex] = appendedObj;

            return true;
        }
        T Indexer(int index)
        {
            return dynamicArray[index];
        }

    }
}
