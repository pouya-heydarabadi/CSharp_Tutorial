// See https://aka.ms/new-console-template for more information
using _05._05;

Console.WriteLine("Hello, World!");
GenericConcat<int>  genericConcatInt = new GenericConcat<int>();
var result = genericConcatInt.Concat(1, 2);
Console.WriteLine(result);

GenericConcat<string> genericConcatString = new GenericConcat<string>();
var resultString = genericConcatString.Concat("Alireza", "Oroumand");
Console.WriteLine(resultString);


GenericConcat<Person> genericConcatPerson = new GenericConcat<Person>();

var resultPerson = genericConcatPerson.Concat( new Person { FirstName = "TestFirstName" , LastName = "TesLastName" }, new Person { FirstName="Arbab", LastName="Arbabi"});
Console.WriteLine(resultPerson);