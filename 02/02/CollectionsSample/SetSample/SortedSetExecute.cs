using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.SetSample;

public sealed class SortedSetExecute
{
    SortedSet<int> objSortedSet = new SortedSet<int>();

    public void Add(int value)
    {
        this.objSortedSet.Add(value);
    }

    public void PrintAll()
    {
        foreach (var item in this.objSortedSet)
        {
            Console.WriteLine(item);
        }
    }
}
