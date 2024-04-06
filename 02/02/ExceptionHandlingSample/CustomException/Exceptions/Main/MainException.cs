namespace _02._02.ExceptionHandlingSample.CustomException;

public class MainException : Exception
{
    public MainException(string? message) : base(message){}
}
