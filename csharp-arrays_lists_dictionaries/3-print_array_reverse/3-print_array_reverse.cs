using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.Write('\n');
            return;
        } else
        {
            Console.Write("{0}", array[array.Length - 1]);
        }
        for (int i = array.Length - 2; i >= 0; i--)
        {
            Console.Write(" {0}", array[i]);
        }
        Console.Write('\n');
    }
}