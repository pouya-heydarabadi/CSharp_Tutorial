using System.Runtime.InteropServices.ObjectiveC;

namespace CSharp._01.NullableType;

public class SimpleNull
{
    public void main()
    {

        // Definition Nullable String 
        string name = null;
        string? nullableName = null;

        // Handle by If Stetements
        if (name is string || !string.IsNullOrWhiteSpace(name))
            Console.WriteLine(name.ToString() + "name");

        Console.WriteLine(nullableName + "nullableName");

        // Error Handeling in Nullable Value Objects
        object _obj1 = null;
        object obj2 = _obj1 ?? throw new NullReferenceException("Value Cannot Be Null");

    }
}
