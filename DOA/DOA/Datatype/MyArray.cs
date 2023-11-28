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

    public void InsertFirst(int value)
    {
        if( _realLength < _intArray.Length)
        {
            for(int i = _realLength -1; i >= 0; i--)
            {
                _intArray[i+1] = _intArray[i];
            }

            _intArray[0] = value;
            _realLength++;
        }
       
        else { Console.WriteLine("Array is allready at maxed capacity"); }
    }

    public void InsertAtIndex(int value, int index)
    {
        if (_realLength < _intArray.Length)
        {
            for (int i = _realLength - 1; i >= index; i--)
            {
                _intArray[i + 1] = _intArray[i];
            }

            _intArray[index] = value;
            _realLength++;
        }
       
        else { Console.WriteLine("Array is allready at maxed capacity"); }
    }

    public void DeleteAtIndex(int index)
    {
        for ( int i = index +1; i<_realLength; i++)
        {
            _intArray[i - 1] = _intArray[i];
        }
        _intArray[_realLength-1] = 0;
        _realLength--;
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

    public int LinearSearchArray( int key)
    {
        for (int i = 0; i < _intArray.Length; i++)
        {
            if (_intArray[i] == key)
            {
                Console.WriteLine($"{key} was found at index: {i}");
                return i;
            }

        }
        Console.WriteLine($"{key} was NOT found in array");
        return -1;
    }
}

