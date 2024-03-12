using System.Runtime.InteropServices;

namespace TestProject1
{
    public class MergeSortTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        
        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        
        Output: [1,2,2,3,5,6]
        
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array1">has all spaces for the merged array</param>
        /// <param name="a1size">The logical size of array1</param>
        /// <param name="array2"></param>
        /// <param name="a2size"></param>
        [Test]
        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)]
        [TestCase(new int[] { 1 }, 1, new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0, new int[] { 1 }, 1)]
        public void TestMergeSortArray(int[] array1, int a1size, int[] array2, int a2size)
        {
            ComAlgLib.MergeSortedArrays merger = new MergeSortedArrays(array1, a1size, array2, a2size);

            merger.PrintArrays();
            merger.MergeArrays();
            merger.PrintArrays();
            Assert.Pass();
        }

        [Test]
        [TestCase(new int[] { 5, 3, 3, 0, 1, 3 }, 3, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 3, 12, 23, 2 }, 1, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1, ExpectedResult = 5)]
        [TestCase(new int[] { 1 }, 1, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 1 }, 1, ExpectedResult = 1)]
        [TestCase(new int[] { 0, 1 }, 0, ExpectedResult = 1)]
        public int TestRemoveElement(int[] array1, int valueToRemove)
        {
            int numFound = 0;
            ComAlgLib.RemoveElement ree = new ComAlgLib.RemoveElement(array1, valueToRemove);
            ree.PrintArray();
            numFound = ree.DoRemoveElement();
            ree.PrintArray();
            Assert.Pass();
            return numFound;
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1, ExpectedResult = new int[] { 7, 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2, ExpectedResult = new int[] { 6, 7, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1 }, 4, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, 5, ExpectedResult = new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 304, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        public int[] TestRotateArray(int[] array1, int rotate)
        {
            ArrayObject.PrintArray(array1);
            int[] array2 = RotateArray.RotateArrayByKNum1(array1, rotate);
            ArrayObject.PrintArray(array2);
            return array2;
        }





    }
}