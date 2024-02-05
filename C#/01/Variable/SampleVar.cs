using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._01.Variable;

public class SampleVar
{
    public void Main()
    {
        // Definition String Variable
        string str1 = new string("string1");
        string str2 = new("string2");
        string str3 = "string3";

        // Definition Int Variable
        int int1 = 1;
        int int2 = 2;

        int intMin = int.MinValue; // -2147483648
        int intMax = int.MaxValue; // 2147483647

        Console.WriteLine($"Int Min value : {intMin} -- Int Max Value : {intMax}");
    }
}
