using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches_and_Sorts
{
    public static class Program
    {
        /// <summary>
        /// Merges two arrays
        /// </summary>
        /// <param name="a"> First array </param>
        /// <param name="b"> Second array </param>
        /// <returns> Merged array from both arrays </returns>
        public static int[] Merge(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            for (int indexA = 0, indexB = 0, indexC = 0; indexC < c.Length; indexC++)
            {
                if (indexA < a.Length && indexB < b.Length && a[indexA] > b[indexB])
                {
                    c[indexC] = b[indexB];
                    indexB++;
                }
                else if (indexA < a.Length)
                {
                    c[indexC] = a[indexA];
                    indexA++;
                }
                else
                    c[indexC] = b[indexB];
            }
            return c;
        }
        
        public static int BinarySearch(int[] arr, int searchKey)
        {
            int mid, max = arr.Length, min = 0;
            while (min <= max)
            {
                mid = (max + min) / 2;
                if (arr[mid] == searchKey)
                    return mid;
                if (arr[mid] > searchKey)
                    max = mid - 1;
                else if (arr[middle] < searchKey)
                    min = mid + 1;
                return -1;
            }
        }
        
        public static int[] BubbleSort(int[] arr)
        {
            for (int write = 0; write < arr.Length; write++)
                for (int sort = 0; sort < arr.Length - 1; sort++)
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
            return arr;
        }
    }
}
