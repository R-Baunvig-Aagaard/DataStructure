using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA.Datatype.Linked_List;

public class Node
{
    public int Data { get; set; }

    public Node? Next { get; set; } = null;

    public void DisplayValue()
    {
        Console.WriteLine(Data);
    }
}
