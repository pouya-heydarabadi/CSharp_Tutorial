using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ArraySample
{
    public static class ArrayDimension
    {
        public static void main()
        {
            int[,] array = new int[1, 1];
            int[,,] array1 = new int[2, 2, 2];
            int[,,,] array2 = new int[3,3,3,3];
            
            array[0, 0] = 1;

            // Init By 0 Value
            array1.Initialize();

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"array rank is {array.Rank}");
            Console.WriteLine($"array1 rank is {array1.Rank}");
            Console.WriteLine($"array2 rank is {array2.Rank}");

        }
    }
}
