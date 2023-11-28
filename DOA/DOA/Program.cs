
/*  Array
    type[] arrayName; 
 */
using DOA.Datatype;

// New int array size/length/capacity of 5
MyArray myArray = new MyArray(5);

// Array Capacity
//Console.WriteLine(intArray.Length);

// Add values to all but last index
myArray.InitArrayExceptLast();
myArray.ReturnLength();

// Print Array
myArray.PrintArray();

//// Insert value at end of array
//myArray.InsertLast(9);
//myArray.ReturnLength();

////// Print Array
//myArray.PrintArray();

//myArray.InsertFirst(9);
//myArray.ReturnLength();

//// Print Array
//myArray.PrintArray();

//myArray.InsertAtIndex(9, 2);
//myArray.ReturnLength();
//myArray.PrintArray();