using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComAlgLib
{
    /*
    You are given two integer arrays nums1 and nums2, 
    sorted in non-decreasing order, and two integers m and n, 
    representing the number of elements in nums1 and nums2 respectively.
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.

    The final sorted array should not be returned by the function, but instead be stored inside the
    array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote 
    the elements that should be merged, and the last n elements are set to 0 and should be ignored.
    nums2 has a length of n.
     
     */
    public class MergeSortedArrays
    {

        private int[] _array1; // main array to merge
        private int _array1Length;
        private int[] _array2; // new set of numbers to merge into array
        private int _array2Length;

        //public MergeSortedArrays(int[] mainArray, int[] mergeArray) : this(mainArray, mainArray.Length, mergeArray, mergeArray.Length)
        //{

        //}

        public MergeSortedArrays(int[] mainArray, int m, int[] mergeArray, int n)
        {
            // DO Checks and validations
            if (mainArray.Length != (m + n))
                throw new ArgumentOutOfRangeException("mainarray must have space for merging, m+n does not equal the length of mainArray");

            this._array1 = mainArray;
            this._array1Length = m;
            this._array2 = mergeArray;
            this._array2Length = n;
        }


        public void MergeArrays()
        {
            // Assign new values to the current array:
            int p = 0;
            // insert key in existing array:
            for (int k = this._array1Length; k < this._array1Length + this._array2Length; k++)
            {
                this._array1[k] = this._array2[p];
                p++;
            }
            // arrays are sorted so:
            // sort values from the end of the main array, since the others are already orders
            // proceed with Sort Merge
            MergeSortedArrays.InsertSort(this._array1);
        }

        /// <summary>
        /// Sorts an array in place
        //  Preconditions, an unsorted array
        //  post conditions, a sorter array 
        /// </summary>
        /// <param name="arrayToSort"></param>
        public static void InsertSort(int[] arrayToSort)
        {
            // Start with the second position
            for (int j = 1; j < arrayToSort.Length; j++)
            {
                // pick current number to sort
                int key = arrayToSort[j];
                int i = j - 1; // set to previous position to compare first time.
                while (i >= 0 && arrayToSort[i] > key)
                {
                    // Move values to the right until number is key is smaller
                    arrayToSort[i + 1] = arrayToSort[i];
                    i = i - 1;
                }
                arrayToSort[i + 1] = key;
            }
        }

        /// <summary>
        /// Prints the main array containing the values
        /// </summary>
        public void PrintArrays()
        {
            Console.WriteLine("Main Array:");
            this.PrintArray(this._array1);
            
            Console.WriteLine("Array to Merge:");
            this.PrintArray(this._array2);

        }

        public void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}", arr[i]);
                if (i != arr.Length - 1)
                    Console.Write(",");
            }
            Console.Write("]");
            Console.WriteLine();
        }

    }


}
