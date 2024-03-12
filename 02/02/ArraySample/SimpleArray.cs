using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ArraySample
{
    public class SimpleArray
    {
        // Array Use for Many Object Equal Type
        // Note: Indexer In Array Only Integer Type

        int[] newIntArray = new int[] { 1 };
        int[] newIntArray1 = new int[2];
        int[] newIntArray2 = { 1, 2, 3, 4, 5 };

        public void main()
        {
            try
            {
                Console.WriteLine(newIntArray[0]);

                // Error Index Out Of Range At Element
                Console.WriteLine(newIntArray[3]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Validation Data");
            }

        }
    }
}
