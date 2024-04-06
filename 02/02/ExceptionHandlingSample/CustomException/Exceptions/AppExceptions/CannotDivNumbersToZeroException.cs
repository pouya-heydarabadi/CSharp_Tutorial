using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.ExceptionHandlingSample.CustomException;

public sealed class CannotDivNumbersToZeroException : MainException
{
    public CannotDivNumbersToZeroException() : base("You Cannot Div Numbers To 0 Because It Is Anwser  Infinity"){}
}
