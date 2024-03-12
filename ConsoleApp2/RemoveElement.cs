using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComAlgLib
{
    public class RemoveElement
    {
        private int[] intArray;
        private int value;

        public RemoveElement(int[] array1, int value)
        {
            this.intArray = array1;
            this.value = value;

        }


    

        public int DoRemoveElement()
        {
            int numValuesFound = 0;
            for (int i = 0; i < this.intArray.Length; i++)
            {
                // see if current i position has the value
                if (this.intArray[i] == this.value)
                {
                    int j = i + 1;
                    numValuesFound++;
                    // i position has the value, need to find a place to move it too
                    while (j < this.intArray.Length)
                    {
                        if (this.intArray[j] != this.value)
                        {
                            // found a spot to put it in the j index.
                            this.intArray[i] = this.intArray[j];
                            // Since value is == to this.intArray[i] ,we can use value.
                            this.intArray[j] = this.value;
                            break;//we found a place, we can move on.
                        }
                        j++;
                    }
                }
            }
            return numValuesFound;
        }


        public void PrintArray()
        {

            Console.Write("[");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0}", intArray[i]);
                if (i != intArray.Length - 1)
                    Console.Write(",");
            }
            Console.Write("]");
            Console.WriteLine();
        }


    }
}
