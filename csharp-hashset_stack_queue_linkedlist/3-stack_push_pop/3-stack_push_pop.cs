using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        } else
        {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));
        if (aStack.Contains(search))
        {
            // this is literally impossible to do without multiple .Pop() calls or some stupid workaround. So, here's my stupid workaround!
            Action popAction = () => aStack.Pop();
            while (aStack.Peek() != search)
            {
                popAction();
            }
            popAction();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
