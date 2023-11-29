using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA.Datatype.Linked_List;

public class LinkedList
{
    // First Node/ Head of linked list
    public Node Head { get; set; }

    public void InsertFirst(int value)
    {
        // New Node
        Node newHead = new Node();
        // Put Data in new Node
        newHead.Data = value;
        // Assign old head as newHead next
        newHead.Next = Head;
        // Assign newHead node as Head node
        Head = newHead;
    }
    public void DeleteFirst()
    {
        Node temp = Head;
        Head = temp.Next;
    }

    public void DisplayLinkedList()
    {
        Console.WriteLine("Display linked list:");
        Node current = Head;
        while (current != null)
        {
            current.DisplayValue();
            current = current.Next;
        }
    }
}
