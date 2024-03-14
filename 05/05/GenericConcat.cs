using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._05
{
    public class GenericConcat<TInput>
    {
        public string Concat(TInput right, TInput left)
        {
            var stringRight = right.ToString();
            var stringLeft = left.ToString();
            var result = $"Right String is {stringRight} and Left String is {stringLeft}";
            return result ;

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"First Name = {FirstName} and Last Name = {LastName}";

        }
    }
}
