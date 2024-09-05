using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
        }
        if (size > 0)
        {
            Console.Write("0");
        }
        for (int i = 1; i < size; i++)
        {
            Console.Write(" {0}", array[i]);
        }
        Console.Write('\n');
        return array;
    }
}