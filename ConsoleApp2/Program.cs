using ComAlgLib;
using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComAlgLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int rotate = 4;
            Console.WriteLine("Hello, World!\nrotating the Array {0} times:", rotate);
            ArrayObject.PrintArray(array1);
            int[] array2 = RotateArray.RotateArrayByKNum1(array1, rotate);
            Console.WriteLine("New Array rotated {0} times:", rotate);
            ArrayObject.PrintArray(array2);

        }


    }

}