using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.ImmutableCollectionSample;

public sealed class ImmutableCollectionExecution
{
    ImmutableList<int> objImmutableList = ImmutableList.Create<int>(1,2,3,4);

    public void PrintAll()
    {
        foreach (var item in objImmutableList)
        {
            Console.WriteLine(item);
        }
    }
}
