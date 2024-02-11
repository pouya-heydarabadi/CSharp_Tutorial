namespace CSharp._02.RecordAndClass.Record;

// Standard Property Record OR Nominal Record
public record NominalPersonRecord
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}