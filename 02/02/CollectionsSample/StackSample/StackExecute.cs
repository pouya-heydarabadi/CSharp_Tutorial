using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.CollectionsSample.StackSample;

public class StackExecute<Type>
{
    public Stack<Type> objStack = new Stack<Type>();

    public void Execute(IList<Type> dataToAdd)
    {
        foreach (var item in dataToAdd)
        {
            Add(item);
        }

        foreach (var item in dataToAdd)
        {
            Console.WriteLine(Get());
        }
    }

    public void Add(Type newInput)
    {
        objStack.Push(newInput);
    }

    public Type Get()
    {
        return objStack.Pop();
    }
}
