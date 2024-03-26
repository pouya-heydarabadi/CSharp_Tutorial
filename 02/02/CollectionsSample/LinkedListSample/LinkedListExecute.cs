namespace _02._02.CollectionsSample.LinkedListSample;

public class LinkedListExecute<Type>
{
    public LinkedList<Type> objLinkedList = new LinkedList<Type>();

    public void Execute(IList<Type> newDataForAdd)
    {
        foreach (var item in newDataForAdd)
        {
            Add(item);
        }
        WriteAll();

        Console.WriteLine("--- Before Remove ---");
        Remove(newDataForAdd.FirstOrDefault());
        WriteAll();
    }

    public void Add(Type newData)
    {
        objLinkedList.AddFirst(newData);
    }

    public void Remove(Type removeData)
    {
        objLinkedList.Remove(removeData);
    }

    public void WriteAll()
    {
        var findCount = objLinkedList.Count();
        for (int i = 0; i < findCount; i++)
        {
            Console.WriteLine(objLinkedList.ElementAtOrDefault(i));
        }
    }
}
