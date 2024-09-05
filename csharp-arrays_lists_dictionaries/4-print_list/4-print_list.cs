using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        for (int i = 0; i < size; i++)
        {
            if (list.Count > 0)
            {
                Console.Write(' ');
            }
            list.Add(i);
            Console.Write(i);
        }
        Console.Write('\n');
        return list;
    }
}
