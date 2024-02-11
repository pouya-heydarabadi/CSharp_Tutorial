namespace CSharp._02.RecordAndClass.Class;

public class NormalPersonClass
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public NormalPersonClass(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    #region Ctors

    #endregion
}
