using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class BinarySearcher<T>
    {
        public static int BinarySearch(IList<T> array,T value,IComparer<T> comparator )
        {
            if (comparator.Compare(value,array[array.Count]) > 0 || comparator.Compare(value,array[0]) < 0)  return -1;
            int leftBorder = 0, rightBorder = array.Count, average;
            while (leftBorder < rightBorder)
            {
                average = (leftBorder + rightBorder) / 2;
                if (comparator.Compare(value, array[average]) < 0)
                    rightBorder = average;
                else if (comparator.Compare(value, array[average]) > 0)
                    leftBorder = average + 1;
                else
                    return average;
            }
            return -1;
        }
    }
}
