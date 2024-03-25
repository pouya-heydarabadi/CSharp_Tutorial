using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Delegates.LamdaExperssions;

public class LambdaExperssionsExecute
{
    public void Execute()
    {
        Action<int> action1 = x
            => Console.WriteLine(x);
        action1(2);

        Func<int, string> func1 = x
            => $"{nameof(x)}";
        func1(3);

            Func<int, int, int> func2 = (x, y)
            => x + y;
        func2(2, 3);
        ;
    }
}
