using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA.Datatype;

public class MyArray
{
    private int _realLength = 0;
    private int[] _intArray;
    public MyArray(int value)
    {
        _intArray = new int[value];
    }
    public void InitArrayExceptLast()
    {
        for (int i = 0; i < _intArray.Length - 1; i++)
        {
            _intArray[i] = i + 1;
            _realLength++;

        }
        
    }
    public void InsertLast(int value)
    {
        _intArray[_realLength] = value;
        _realLength++;
        
    }

    public int ReturnLength()
    {
        Console.WriteLine($"Length: {_realLength}");
        return _realLength;
    }

    public void PrintArray()
    {
        foreach (int i in _intArray)
        {
            Console.WriteLine(i);
        }
    }
}

