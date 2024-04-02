using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.SortedDictionarySample;

public sealed class SortedDictionaryExecution
{
    SortedDictionary<int, string> objSortedDictionary = new SortedDictionary<int, string>();

    public void Add(int key, string value)
    {
        objSortedDictionary.Add(key, value);
    }

    public void PrintAll()
    {
        foreach (var item in objSortedDictionary)
        {
            Console.WriteLine(item.Value);
        }
    }

    public void Get(int key)
    {
        bool result = objSortedDictionary.TryGetValue(key, out string value);

        if(result)
            Console.WriteLine(value);
    }
}
