using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Struct.Functions;

public class StructExec
{
    public void Execute()
    {
        ReadonlyNormalPersonStruct _objNewRealOnlyPersonStruct = new ReadonlyNormalPersonStruct(id: 1, firstName: "pouya");
        Console.WriteLine(value: _objNewRealOnlyPersonStruct);

        PrimaryPersonStruct _objNewPrimaryPersonStruct = new PrimaryPersonStruct(Id: 1, "Pouya", "Heydarabadi");
        Console.WriteLine(_objNewPrimaryPersonStruct);
    }
}
