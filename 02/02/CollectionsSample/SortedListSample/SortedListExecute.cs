using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.SortedListSample;

public class SortedListExecute<Value>
{
    public SortedList<int, Value> objSortedList = new SortedList<int, Value>();
    public int KeyCounter = 0;
    public void Execute(IList<Value> values)
    {
        foreach (var item in values)
        {
            Add(item);
        }

        WriteAll();
    }

    public void Add(Value value)
    {
        objSortedList.Add(KeyCounter, value);
        KeyCounter++;
    }

    public void Remove(int key)
    {
        objSortedList.Remove(key);
    }

    public void WriteAll()
    {
        int indexerA = 0;
        foreach (var item in objSortedList)
        {
            Console.WriteLine($"Index:{indexerA} -- Key:{item.Key} -- Value:{item.Value}");
            indexerA += 1;
        }
    }
}
