using _02._02.ExceptionHandlingSample.CustomException;

namespace _02._02.ExceptionHandlingSample;

public sealed class CustomExceptionHandlingExecute
{
    public decimal DivTwoNumber(int number1, int number2)
    {
        try
        {
            if (number2.Equals(0))
                throw new CannotDivNumbersToZeroException();
            decimal result = number1 / number2;
            return result;
        }

        catch (CannotDivNumbersToZeroException ex) when (!string.IsNullOrEmpty(ex.Message))
        {
            Console.WriteLine("Error!!!!");
            Console.WriteLine(ex.Message);
            return 0;
        }

        catch (Exception)
        {
            // Handle Exception
            Console.WriteLine("UnHandled Exception");
            return 0;
        }

        finally
        {
            Console.WriteLine("Finally!!!!");
        }
    }
}
