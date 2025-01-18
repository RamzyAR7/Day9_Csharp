using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Csharp_Part02
{
    internal static class Generics
    {
        public static T[] ReverseArray<T>(T[] inputArray)
        {
            T[] reversedArray = new T[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                reversedArray[i] = inputArray[inputArray.Length - 1 - i];
            }
            return reversedArray;
        }

        // Generic method to swap two elements in an array
        public static void SwapElements<T>(T[] array, int index1, int index2)
        {
            if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static T FindMaximum<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty.");
            }

            T max = array[0];

            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

    }
}
