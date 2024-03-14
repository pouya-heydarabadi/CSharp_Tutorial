using _02._02.Delegates.Delegate.Models;

namespace _02._02.Delegates.Delegate
{
    public static class DelegateSample
    {
        public delegate string CalculateFullName(Person person);

        public static void Execute(CalculateFullName personDelegate, Person person)
        {
            Console.WriteLine(personDelegate(person));
        }

        public static string CalculateFullName1(Person person)
            => person.FirstName + person.LastName;
        public static string CalculateFullName2(Person person)
            => person.FirstName + "-" + person.LastName;
    }
}
