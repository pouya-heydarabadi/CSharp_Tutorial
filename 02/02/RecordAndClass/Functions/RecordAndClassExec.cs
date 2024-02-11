using CSharp._02.RecordAndClass.Class;
using CSharp._02.RecordAndClass.Record;

namespace _02._02.RecordAndClass.Functions;

public class RecordAndClassExec
{
    public void Execute()
    {

        #region Record VS Class
        #region Class

        // Normal Class
        NormalPersonClass _objNewNormalPersonClass1 = new(id: 1, firstName: "Pouya", lastName: "Heydarabadi");
        NormalPersonClass _objNewNormalPersonClass2 = new(id: 1, firstName: "Pouya", lastName: "Heydarabadi");
        NormalPersonClass _objNewNormalPersonClass3 = new(id: 2, firstName: "AliReza", lastName: "Rezaei");

        // In any case, these two objects are not equal because the class does not have this capability in normal mode
        Console.WriteLine(value: _objNewNormalPersonClass1 == _objNewNormalPersonClass2);
        Console.WriteLine(value: _objNewNormalPersonClass1 == _objNewNormalPersonClass3);

        Console.WriteLine("------------------------");

        // Primary Class 
        PrimaryPersonClass _objNewPrimaryPersonClass1 = new PrimaryPersonClass(Id: 1, FirstName: "Pouya", LastName: "Heydarabadi");
        PrimaryPersonClass _objNewPrimaryPersonClass2 = new PrimaryPersonClass(Id: 1, FirstName: "Pouya", LastName: "Heydarabadi");
        PrimaryPersonClass _objNewPrimaryPersonClass3 = new PrimaryPersonClass(Id: 2, FirstName: "Pouya", LastName: "Heydarabadi");

        Console.WriteLine(value: _objNewPrimaryPersonClass1 == _objNewPrimaryPersonClass2); // False
        Console.WriteLine(value: _objNewPrimaryPersonClass1 == _objNewPrimaryPersonClass3); // False

        Console.WriteLine("------------------------");
        #endregion

        #region Record
        NominalPersonRecord _objNewNominalPersonRecord1 = new NominalPersonRecord()
        {
            Id = 1,
            FirstName = "Pouya",
            LastName = "Heydarabadi"
        };

        NominalPersonRecord _objNewNominalPersonRecord2 = new NominalPersonRecord()
        {
            Id = 1,
            FirstName = "Pouya",
            LastName = "Heydarabadi"
        };

        NominalPersonRecord _objNewNominalPersonRecord3 = new NominalPersonRecord()
        {
            Id = 2,
            FirstName = "Pouya",
            LastName = "Heydarabadi"
        };

        // Equality of two records with exactly the same values is correct
        Console.WriteLine(_objNewNominalPersonRecord1 == _objNewNominalPersonRecord2); // ُTrue
        Console.WriteLine(_objNewNominalPersonRecord1 == _objNewNominalPersonRecord3); // False

        Console.WriteLine("------------------------");

        PositionalPersonRecord _objNewPositionalPersonRecord1 = new PositionalPersonRecord(1, "Pouya", "Heydarabadi");
        PositionalPersonRecord _objNewPositionalPersonRecord2 = new PositionalPersonRecord(1, "Pouya", "Heydarabadi");
        PositionalPersonRecord _objNewPositionalPersonRecord3 = new PositionalPersonRecord(2, "Pouya", "Heydarabadi");

        Console.WriteLine(_objNewPositionalPersonRecord1 == _objNewPositionalPersonRecord2); // ُTrue
        Console.WriteLine(_objNewPositionalPersonRecord1 == _objNewPositionalPersonRecord3); // False

        Console.WriteLine("------------------------");

        PositionalPersonRecord _objNewCopyFromPositionalPersonRecord1 = _objNewPositionalPersonRecord1 with { Id = 3 };
        Console.WriteLine($"Copy => {_objNewCopyFromPositionalPersonRecord1}");

        #endregion

        #endregion
    }
}
