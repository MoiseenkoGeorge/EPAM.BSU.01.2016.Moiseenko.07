using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class BubbleSorter
    {
        public static void BubbleSort<T>(this T[] array, Comparison<T> comparison)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (comparison(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
        }
        private static void Swap<T>(ref T left,ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }
    }
}
