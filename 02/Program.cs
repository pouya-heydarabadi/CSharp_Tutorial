using System.Runtime.CompilerServices;

using _02._02.CollectionsSample.DictionarySample;
using _02._02.CollectionsSample.LinkedListSample;
using _02._02.CollectionsSample.ListSample;
using _02._02.CollectionsSample.QueueSample;
using _02._02.CollectionsSample.SortedDictionarySample;
using _02._02.CollectionsSample.SortedListSample;
using _02._02.CollectionsSample.StackSample;
using _02._02.Delegates.AnonymouseMethods;
using _02._02.Delegates.Events;
using _02._02.Delegates.LamdaExperssions;
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
//MultiCastExecute objMultiCastExecute = new MultiCastExecute();
//objMultiCastExecute.ExecuteWithOutOutput();
#endregion

#region Anonymouse Method

//AnonymousMethodExecute objNewAnonymousMethod = new();
//objNewAnonymousMethod.Execute();

#endregion

#region Labmda Experssions
//LambdaExperssionsExecute objLambdaExperssionsExecute = new();
//objLambdaExperssionsExecute.Execute();
#endregion

#region Event
//EventExecute objNewEventExec = new();
//objNewEventExec.Execute();
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

#region Collections
#region List
//ListSampleExecute<string> listSampleExecute_string = new ListSampleExecute<string>();

//// Capacity Is 0-4-8-16-32-64-128-256-512-1024 ,...
//listSampleExecute_string.ReturnCapacity();
//listSampleExecute_string.AddMember("pouya");
//listSampleExecute_string.ReturnCapacity();
//listSampleExecute_string.AddMember("alireza");
//listSampleExecute_string.ReturnCapacity();
//listSampleExecute_string.AddMember("pedram");
//listSampleExecute_string.AddMember("milad"); 
//listSampleExecute_string.ReturnCapacity();// Capacity Is 4

//listSampleExecute_string.AddMember("masoud");
//listSampleExecute_string.ReturnCapacity(); // Capacity Is 8
//Console.WriteLine($"Start -- {nameof(ListSampleExecute<int>)}"+ Environment.NewLine);

////perf: You Can Improve Performance With Set Capacity Manual When Init List 
//// Because Is Best For Memory Allocation And ...

//ListSampleExecute<int> listSampleExecute_int = new ListSampleExecute<int>();
//listSampleExecute_int.SetCapacity(10);
//listSampleExecute_int.AddMember(1);
//listSampleExecute_int.ReturnCapacity();

//// You Can Trim Unnecessary  
//listSampleExecute_int.Trim();
//listSampleExecute_int.ReturnCapacity();

//// Here Class My List Is ReadOnly 
//// But In This BaseClass List Type Is NotReadOnly 
//listSampleExecute_int.ConvertToReadOnlyList();
//listSampleExecute_int.AddMember(23);
//;
#endregion

#region Queue

//QueueExecute<int> queue1 = new QueueExecute<int>();

//queue1.EnQueue(1);
//queue1.EnQueue(2);
//queue1.EnQueue(3);

//queue1.WriteAllElements();
//queue1.WriteCount();

//Console.WriteLine("---Peak----");



//queue1.Peak();
//queue1.WriteCount();
//queue1.Peak();
//queue1.WriteCount();
//queue1.Peak();
//queue1.WriteCount();

//Console.WriteLine("---DeQueue----");

//queue1.DeQueue();
//queue1.WriteCount();
//queue1.DeQueue();
//queue1.WriteCount();
//queue1.DeQueue();
//queue1.WriteCount();

#endregion

#region PriorityQueue
//PriorityQueueSample<int, int> priorityQueueSample = new PriorityQueueSample<int, int>();
//priorityQueueSample.Add(1, 1);
//priorityQueueSample.Add(5, 2);
//priorityQueueSample.Add(7, 4);
//priorityQueueSample.Add(9, 3);
//priorityQueueSample.Add(11, 5);

//Console.WriteLine("-----Peek------");
//int findQueueCount = priorityQueueSample.objPriorityQueue.Count;

//for (int i = 0; i < findQueueCount; i++)
//{
//    Console.WriteLine(priorityQueueSample.Peek());
//}
//Console.WriteLine("-----DeQueue------");

//for (int i = 0; i < findQueueCount; i++)
//{
//    Console.WriteLine(priorityQueueSample.DeQueue());
//}


#endregion

#region Stack
//StackExecute<int> stackExecute = new StackExecute<int>();
//stackExecute.Execute(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });
#endregion

#region LinkedList
//LinkedListExecute<string> linkedListExecute = new LinkedListExecute<string>();
//linkedListExecute.Execute(new List<string> { "pouya", "hamid", "reza" });
#endregion

#region SortedList
//SortedListExecute<string> objSortedListExecute = new SortedListExecute<string>();

//objSortedListExecute.Execute(new List<string>
//{
//    "alireza",
//    "sara",
//    "hossein",
//    "milad"
//});


#endregion

#region Dictionary

//DictionaryExecution dictionaryExecution = new DictionaryExecution();

//dictionaryExecution.Add(1, "pouya");
//dictionaryExecution.Add(2, "sara");

//Console.WriteLine(dictionaryExecution.Get(1));
//dictionaryExecution.PrintAll();

#endregion

#region Sorted Dictionary
SortedDictionaryExecution sortedDictionaryExecution = new SortedDictionaryExecution();

sortedDictionaryExecution.Add(1, "hi");
sortedDictionaryExecution.Add(2, "salam");

sortedDictionaryExecution.PrintAll();

sortedDictionaryExecution.Get(2);

#endregion

#endregion
Console.ReadLine();