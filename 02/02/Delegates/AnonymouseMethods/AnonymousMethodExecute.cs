using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

using _02._02.Delegates.Delegate.Models;

namespace _02._02.Delegates.AnonymouseMethods;

public class AnonymousMethodExecute
{
    public void Execute()
    {
        // Init New Person
        Person objNewPerson = new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = "pouya",
            LastName = "heydarabadi"
        };

        var sample = delegate (Person person)
        {
            return $"{person.FirstName}";
        };

        var result = sample(objNewPerson);
        Console.WriteLine(result);
    }
}
