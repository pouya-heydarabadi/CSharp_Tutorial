namespace _02._02.CollectionsSample.SetSample;

public sealed class HashSetExecute
{
    HashSet<int> objHashSet = new HashSet<int>();

    public void Add(int value)
    {
        this.objHashSet.Add(value);
    }

    public void PrintAll()
    {
        foreach (var item in this.objHashSet)
        {
            Console.WriteLine(item);
        }
    }
}
