using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace ComAlgLib
{
    public class ArrayObject
    {
        protected int[] array1;
        private ArrayObject()
        {
            this.array1 = new int[0];// array with no objects
        }
        public ArrayObject(int[] array1)
        {
            this.array1 = array1;
        }

        /// <summary>
        /// This is the card Insert Sort algorithm, it can be used to sort an array in place
        /// </summary>
        public void InsertSort()
        {
            // Start with the second position
            for (int j = 1; j < array1.Length; j++)
            {
                // pick current number to sort
                int key = array1[j];// Pickup the current value, this essentially frees up this j position so that we can shift numbers to the right (or insert it in the same position)
                int i = j - 1; // set to previous position to compare first time.
                // Iterate from the current end to the first position top compare where to insert the value
                while (i >= 0 && array1[i] > key)
                {
                    // Move values to the right until number is key is smaller
                    array1[i + 1] = array1[i];
                    i = i - 1;
                }
                array1[i + 1] = key;
            }
        }



        /// <summary>
        /// Removes duplicates from array
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such 
        /// that each unique element appears only once. The relative order of the elements should be kept the same. 
        /// Then return the number of unique elements in nums.
        /// Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
        /// Change the array nums such that the first k elements of nums contain the unique elements in the order they were 
        /// present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        /// 
        /// 
        /// 
        /// 
        /// Return k.
        /// </summary>
        /// <returns></returns>
        public int RemoveDuplicates()
        {
            for(int i = 0;i<=10;i++)
            {
                //do something
            }
            return 0;
        }

        #region Utility functions 

        public void PrintArray()
        {
            ArrayObject.PrintArray(this.array1);

        }

        public static void PrintArray(int[] array1)
        {
            Console.Write("[");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0}", array1[i]);
                if (i != array1.Length - 1)
                    Console.Write(",");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        #endregion

    }
}
