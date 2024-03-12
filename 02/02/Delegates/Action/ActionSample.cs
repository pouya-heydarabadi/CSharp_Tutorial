using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _02._02.Delegates.Action
{
    public static class ActionSample
    {
        public static void Main(Action<int, int> action, int[] input)
        {
            action(input[0], input[1]);
        }
        public static void Calc1(int a, int b)
            => Console.WriteLine(a + b);
        public static void Calc2(int a, int b)
            => Console.WriteLine(a * b);
    }
}
