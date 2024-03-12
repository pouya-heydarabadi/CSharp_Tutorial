using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ArraySample
{
    public static class JaggedArray
    {
        public static void main()
        {
            int[][] array1 = new int[2][];
            array1[0] = new int[]{ 1, 2, 3, 4, 5 };
            array1[1] = new int[] { 6, 7, 8, 9, 10, 11, 12 };

            foreach (int[] item in array1)
            {
                List<int> test = new List<int>();
                foreach (int itemInArray in item)
                {
                    Console.Write(itemInArray + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
