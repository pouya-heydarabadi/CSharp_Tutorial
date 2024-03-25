using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.ListSample;

public class ListSampleExecute<T>
{

    public List<T> objectList { get; set; }

    public ListSampleExecute()
    {
        objectList = new List<T>();
    }

    public void ReturnCapacity()
    {
        Console.WriteLine(objectList.Capacity);
    }

    public void AddMember(T member)
    {
        this.objectList.Add(member);
    }

    public void SetCapacity(int newCapacity)
    {
        this.objectList.EnsureCapacity(newCapacity);
    }

    public void Trim()
    {
        this.objectList.TrimExcess();
    }

    public void Remove(T item)
    {
        this.objectList.Remove(item);
    }

    public void RemoveAll()
    {
        // Pass Peridicate Arg For RemoveAll
        //this.objectList.RemoveAll();
    }

    public void RemoveAt(int index)
    {
        this.objectList.RemoveAt(index);
    }

    public void RemoveRange(int start, int end)
    {
        this.objectList.RemoveRange(start, end);
    }

    public void ConvertToReadOnlyList()
    {
        this.objectList.AsReadOnly();
    }
}
