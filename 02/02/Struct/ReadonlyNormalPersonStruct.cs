using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Struct;

public readonly struct ReadonlyNormalPersonStruct
{
    public int? Id { get; }
    //public string FirstName { get; private set; } // Give My Error Because We Cannot Set Value In Readonly
    public string FirstName { get; init; }

    public ReadonlyNormalPersonStruct(int? id, string firstName)
    {
        Id = id;
        FirstName = firstName;
    }

    public override string? ToString()
    {
        return $"Id: {this.Id} -- FirstName: {this.FirstName}";
    }
}
