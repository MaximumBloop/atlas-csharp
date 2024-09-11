using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        if (n < 0 || myLList.Count == 0)
        {
            return 0;
        }
        for (int i = 0; i < myLList.Count && i < n; i++)
        {
            current = current.Next;
            if (current == null)
            {
                return 0;
            }
        }
        return current.Value;
    }
}