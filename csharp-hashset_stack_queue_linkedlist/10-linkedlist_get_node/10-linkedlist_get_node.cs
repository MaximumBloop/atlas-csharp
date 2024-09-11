using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < myLList.Count && i < n; i++)
        {
            if (current == null)
            {
                return 0;
            }
            current = current.Next;
        }
        return current.Value;
    }
}