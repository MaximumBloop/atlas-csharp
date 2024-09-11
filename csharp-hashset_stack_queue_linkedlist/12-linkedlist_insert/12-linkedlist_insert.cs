using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;

        if (newNode.Value <= current.Value)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        while (current.Next != null && current.Value < newNode.Value)
        {
            current = current.Next;
        }

        if (current.Next == null && current.Value < newNode.Value)
        {
            myLList.AddAfter(current, newNode);
        } else
        {
            myLList.AddBefore(current, newNode);
        }
        return (newNode);
    }
}