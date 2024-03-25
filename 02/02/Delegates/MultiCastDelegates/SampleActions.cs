using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Delegates.MultiCastDelegates;

public class SampleActions
{
    public void CW1()
        => Console.WriteLine($"Hello {nameof(CW1)}");

    public void CW2()
        => Console.WriteLine($"Hello {nameof(CW2)}");

    public void CW3()
        => Console.WriteLine($"Hello {nameof(CW3)}");

    public void CW4()
        => Console.WriteLine($"Hello {nameof(CW4)}");
}
