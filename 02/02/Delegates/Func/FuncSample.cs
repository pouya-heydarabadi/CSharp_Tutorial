using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Delegates.Delegate.Func
{
    public static class FuncSample
    {
        public static void Main(Func<int,int,int,int> func, int[] input)
        {
            int result = func(input[0], input[1], input[2]);

            Console.WriteLine($"Func Calculator:{result}");
        }
        public static int Calculator(int a, int b, int c)
            => a + b + c;
        public static int Calculator2(int a, int b, int c)
            => a * b * c;
    }
}
