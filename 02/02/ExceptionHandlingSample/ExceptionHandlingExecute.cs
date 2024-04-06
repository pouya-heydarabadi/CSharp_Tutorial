namespace _02._02.ExceptionHandlingSample;

public sealed class ExceptionHandlingExecute
{
    public decimal DivTwoNumber(int number1, int number2)
    {
		try
		{
            int result = number1 / number2;
            return result;
        }
		catch (Exception)
		{
            // Handle Your Exception
            return 0;
		}
    }
}
