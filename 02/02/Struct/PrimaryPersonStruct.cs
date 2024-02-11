using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Struct;

public struct PrimaryPersonStruct(int Id, string FirstName, string LastName)
{
    public override string? ToString()
    {
        return $"Id: {Id} -- FirstName: {FirstName} -- LastName: {LastName}";
    }
};
