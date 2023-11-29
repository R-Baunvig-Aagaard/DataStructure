using DOA.Datatype;
using DOA.Datatype.Linked_List;
using System.Collections.Generic;

#region Array
/*  Array
    type[] arrayName; 
 */


////New int array size/length/capacity of 5
//MyArray myArray = new MyArray(5);

////Add values to all but last index
//myArray.InitArrayExceptLast();
//myArray.ReturnLength();

//// Print Array
//myArray.PrintArray();

//// Insert value at end of array
//myArray.InsertLast(9);
//myArray.ReturnLength();

////Print Array
//myArray.PrintArray();

//myArray.InsertFirst(9);
//myArray.ReturnLength();

//// Print Array
//myArray.PrintArray();

//myArray.InsertAtIndex(9, 2);
//myArray.ReturnLength();
//myArray.PrintArray();

//myArray.DeleteAtIndex(1);
//myArray.ReturnLength();

////Print Array
//myArray.PrintArray();

//var result = myArray.LinearSearchArray(2);


//List<int> testList = new List<int>();

#endregion

#region linked list

/* Linked List
 * 

 */
//Node myNode = new Node();
//myNode.Data = 3;
//LinkedList myLinkedList = new LinkedList();

//myLinkedList.InsertFirst(8);
//myLinkedList.Head.Next = myNode;
//myLinkedList.Head.DisplayValue();
//myLinkedList.Head.Next.DisplayValue();
//myLinkedList.DeleteFirst();
//myLinkedList.Head.DisplayValue();
//myLinkedList.InsertFirst(25);
//myLinkedList.InsertFirst(17);
//myLinkedList.InsertFirst(83);
//myLinkedList.DisplayLinkedList();

//// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0
//string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
//LinkedList<string> sentence = new LinkedList<string>(words);

//Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
//    sentence.Contains("jumps"));

//sentence.AddFirst("First");
//sentence.AddLast("Last");


#endregion

#region Stack
////https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-8.0

//Stack<string> myStack = new Stack<string>();

//myStack.Push("Hello");
//myStack.Push("World");

//Console.WriteLine(myStack.Peek());
//Console.WriteLine(myStack.Contains("Hello"));

//myStack.Pop();
//Console.WriteLine(myStack.Peek());

#endregion

#region Queue
//// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0

//Queue<int> myQueue = new Queue<int>();

//myQueue.Enqueue(1);
//myQueue.Enqueue(2); 
//myQueue.Enqueue(3);
//myQueue.Enqueue(4);

//foreach (int i in myQueue)
//{
//    Console.WriteLine(i);
//}
//// Dequeue first and second in line FIFO
//myQueue.Dequeue();
//myQueue.Dequeue();

//foreach (int i in myQueue)
//{
//    Console.WriteLine(i);
//}
//// Now first in line
//Console.WriteLine(myQueue.Peek());

#endregion

#region Dictionary 
//// Dictionary 

//Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();

//keyValuePairs.Add(1, "Rasmus");
//keyValuePairs.Add(2, "Jacob");
//keyValuePairs.Add(3, "Mikkel");

//Console.WriteLine(keyValuePairs.Count());
//Console.WriteLine(keyValuePairs.ContainsKey(2));
//Console.WriteLine(keyValuePairs[2]);

//Dictionary<string,List<string>> wishList = new Dictionary<string,List<string>>();
//wishList.Add("Rasmus", new List<string> {"Snow","Sun","Rain" });
//wishList.Add("Jacob", new List<string> { "Angry", "Sad", "Happy" });

//foreach (var (key, value) in wishList )
//{
//    Console.WriteLine($"Wishlist for {key}:");
//    foreach (var item in value)
//    {
//        Console.WriteLine($"\t{item}");
//    }
//}

#endregion