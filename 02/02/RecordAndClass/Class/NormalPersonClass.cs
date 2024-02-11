namespace CSharp._02.RecordAndClass.Class;

public sealed class NormalPersonClass
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int? Age{get; init;}

    public NormalPersonClass(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public NormalPersonClass(int id, string firstName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    #region Ctors

    #endregion
}