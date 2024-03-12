using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComAlgLib
{
    public class RotateArray : ArrayObject
    {
        public RotateArray(int[] arr) : base(arr)
        {
        }

        /// <summary>
        /// Creates a new array and assigns the values accordingly
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] RotateArrayByKNum1(int[] arr1, int k)
        {
            if (arr1 == null)
                throw new ArgumentNullException("array cannot be null");
            // Check the array has more than one element, otherwise the result is the same
            if (arr1.Length == 0 || arr1.Length == 1)
                return arr1;

            int[] newArray = new int[arr1.Length];
            
            // final number of times to rotate
            int finalRotate = k % arr1.Length;
            // position of first items for new array
            int arrSplit = arr1.Length - finalRotate; // if array lenght is 7, and k = 2, arrSplit is = 5. Position 5 is where we start to copy
            
            int j = 0;
            for (int i = arrSplit; i < arr1.Length; i++)
            {
                newArray[j++] = arr1[i];
            }

            for (int i = 0; i < arrSplit; i++)
            {
                newArray[j++] = arr1[i];
            }
            return newArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="k"></param>
        public static int[] RotateArrayByKNum2(int[] arr1, int k)
        {
            // Do checks, array has a valid address 
            if (arr1 == null)
                throw new ArgumentNullException("array cannot be null");
            // Check the array has more than one element, otherwise the result is the same
            if (arr1.Length == 0 || arr1.Length == 1)
                return arr1;
            // since rotations are repetitive, we dont need to rotate if k > Lenght
            int finalRotate = k % arr1.Length;
            // rotate array k times:
            for (int i = 0; i < finalRotate; i++)
            {
                // rotate array 1 time:
                int lastNum = arr1.Last();
                for (int j = arr1.Length - 1; j >= 1; j--)
                {
                    // move numbers to the right:
                    arr1[j] = arr1[j - 1];
                }
                //put the last item in the beggining:
                arr1[0] = lastNum;
            }
            return arr1;
        }

    }


}
