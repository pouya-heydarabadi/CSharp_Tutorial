using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.QueueSample;

public class QueueExecute<T>
{
    public Queue<T> objQueueSample1 = new Queue<T>();

    public void EnQueue(T newData)
    {
        objQueueSample1.Enqueue(newData);
    }

    public T DeQueue()
    {
        return objQueueSample1.Dequeue();
    }

    public void WriteAllElements()
    {
        foreach (T item in objQueueSample1)
        {
            Console.WriteLine(item);
        }
    }

    public void WriteCount()
    {
        Console.WriteLine($"Your Queue Count: {objQueueSample1.Count()}");
    }

    public T Peak()
    {
        return objQueueSample1.Peek();
    }

}
