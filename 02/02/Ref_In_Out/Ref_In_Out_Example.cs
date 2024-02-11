using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Ref_In_Out;

public class Ref_In_Out_Example
{
    public void CallerRef()
    {
        int myVar = 1;
        Console.WriteLine($"Before Caller {myVar}");
        CalleRef(ref myVar);
        Console.WriteLine($"After Caller{myVar}");
    }
    public void CalleRef(ref int input)
    {
        input++;
    }

    // 
    public void CallerOut()
    {
        int myVar = 1;
        Console.WriteLine($"Before Caller {myVar}");
        CalleOut(out myVar);
        Console.WriteLine($"After Caller{myVar}");
    }
    public void CalleOut(out int input)
    {
        input =2;
    }


    public void CallerIn()
    {
        int myVar = 1;
        Console.WriteLine($"Before Caller {myVar}");
        CallerIn(in myVar);
        Console.WriteLine($"After Caller{myVar}");
    }
    public void CallerIn(in int input)
    {
        //input = 2;
    }
}
