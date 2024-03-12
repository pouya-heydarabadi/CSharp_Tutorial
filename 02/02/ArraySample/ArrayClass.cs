using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ArraySample
{
    public static class ArrayClass
    {
        public static void main()
        {
            Array array1 = Array.CreateInstance(typeof(int), 4);

            for (int i = 0; i < array1.Length; i++)
            {
                array1.SetValue(i * 2, i);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1.GetValue(i) + " "); 
            }
        }

        public static void Copy()
        {
            var array1 = Array.CreateInstance(typeof(string), 10);
            int[] array2 = new int[5];
            var array3 = array1.Clone();

            Array.Copy(array1, array2, 5);
        }
    }
}
