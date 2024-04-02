namespace _02._02.CollectionsSample.DictionarySample;

public class DictionaryExecution
{
    Dictionary<int, string> objDictionary = new Dictionary<int, string>();

    public void Add(int key, string value)
    {
        objDictionary.Add(key, value);
    }

    public void PrintAll()
    {
        foreach (var item in objDictionary)
        {
            Console.WriteLine(item.Value);
        }
    }

    public string Get(int key)
    {
        bool result = objDictionary.TryGetValue(key, out var value);
        if (result)
            return value;
        return null;
    }


}
