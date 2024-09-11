using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = -1;
        if (!(myLList.Contains(value)))
        {
            return -1;
        }
        for (LinkedListNode<int> node = myLList.First; node != null; node = node.Next)
        {
            i++;
            if (node.Value == value)
            {
                break;
            }
        }
        return i;
    }
}
