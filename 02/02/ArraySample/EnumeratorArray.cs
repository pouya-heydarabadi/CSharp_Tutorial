using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ArraySample
{
    public static class EnumeratorArray
    {
        public static void Main()
        {
            int[] newArray = { 1, 2, 3, 4, 5 };

            var getEnumerator = newArray.GetEnumerator();

            while (getEnumerator.MoveNext())
            {
                Console.WriteLine(getEnumerator.Current);
            }
        }
    }
}
