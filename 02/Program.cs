using _02._02.Delegates.MultiCastDelegates;

#region Record And Class
//RecordAndClassExec _objNewRecordVsClass = new RecordAndClassExec();
//_objNewRecordVsClass.Execute();
#endregion

#region Struct
//StructExec _objStructExecute = new StructExec();
//_objStructExecute.Execute();
#endregion

#region Ref In Out
//Ref_In_Out_Example _objNewRefrence = new Ref_In_Out_Example();
//_objNewRefrence.CallerRef();
//_objNewRefrence.CallerOut();
//_objNewRefrence.CallerIn();
#endregion

#region Array
//SimpleArray _objNewArray = new SimpleArray();
//_objNewArray.main();
//ArrayDimension.main();
//JaggedArray.main();
//ArrayClass.main();
//EnumeratorArray.Main();
#endregion

#region Delegates

#region Del
//Person objNewPerson = new()
//{
//    Id = Guid.NewGuid(),
//    FirstName = "Pouya",
//    LastName = "Heydarabadi"
//};
//DelegateSample.Execute(DelegateSample.CalculateFullName1,
//    person: objNewPerson);

//Console.WriteLine(Environment.NewLine);

//DelegateSample.Execute(DelegateSample.CalculateFullName2,
//    person: objNewPerson);
#endregion

#region Action

//int[] input =
//{
//    2,2,3
//};

//ActionSample.Main(ActionSample.Calc1, input);
//ActionSample.Main(ActionSample.Calc2, input);

#endregion

#region Func

//int[] input = { 2, 2, 3 };
//FuncSample.Main(FuncSample.Calculator, input);
//Console.WriteLine(Environment.NewLine);
//FuncSample.Main(FuncSample.Calculator2, input);

#endregion

#region MultiCastDelegate

MultiCastExecute objMultiCastExecute = new MultiCastExecute();
objMultiCastExecute.ExecuteWithOutOutput();

#endregion
#endregion

#region Generics
//Console.WriteLine("Hello, World!");
//GenericConcat<int> genericConcatInt = new GenericConcat<int>();
//var result = genericConcatInt.Concat(1, 2);
//Console.WriteLine(result);

//GenericConcat<string> genericConcatString = new GenericConcat<string>();
//var resultString = genericConcatString.Concat("Alireza", "Oroumand");
//Console.WriteLine(resultString);


//GenericConcat<Person> genericConcatPerson = new GenericConcat<Person>();

//var resultPerson = genericConcatPerson.Concat(new Person { FirstName = "TestFirstName", LastName = "TesLastName" }, new Person { FirstName = "Arbab", LastName = "Arbabi" });
//Console.WriteLine(resultPerson);
#endregion
Console.ReadLine();