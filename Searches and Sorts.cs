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
        /// Finds the minimum value of given array
        /// Time complexity: O(n), n = given array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> The minimum value of given array </returns>
        public static int FindMin(int[] arr)
        {
            int min = Int32.MaxValue;
            for (int i = 0, i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }
        
        /// <summary>
        /// Finds the maximum value of given array
        /// Time complexity: O(n), n = given array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> The maximum value of given array </returns>
        public static int FindMax(int[] arr)
        {
            int max = Int32.MinValue;
            for (int i = 0, i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        
        /// <summary>
        /// Finds the index of the minimum value of given array
        /// Time complexity: O(n), n = given array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> The index of the minimum value of given array </returns>
        public static int FindMinLoc(int[] arr)
        {
            int min = Int32.MaxValue, loc = 0;
            for (int i = 0, i < arr.Length; i++)
                if (arr[i] < min)
                {
                    loc = i;
                    min = arr[i];
                }
            return loc;
        }
        
        /// <summary>
        /// Finds the index of the maximum value of given array
        /// Time complexity: O(n), n = given array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> The index of the maximum value of given array </returns>
        public static int FindMaxLoc(int[] arr)
        {
            int max = Int32.MinValue, loc = 0;
            for (int i = 0, i < arr.Length; i++)
                if (arr[i] > max)
                {
                    loc = i;
                    max = arr[i];
                }
            return loc;
        }
        
        /// <summary>
        /// Merges two arrays
        /// Time complexity: O(n + m), n = first array length, m = second array length
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
        
        /// <summary>
        /// Searches given value
        /// Time complexity: O(log2 n), n = array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> Index of given key if exist in the array, else -1 </returns>
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
        
        /// <summary>
        /// Sorts an array
        /// Time complexity: O(n ^ 2), n = array length
        /// </summary>
        /// <param name="arr"> The given array </param>
        /// <returns> The given array, sorted </returns>
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
