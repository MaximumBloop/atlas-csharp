using System;

class Program
{
    public static void Main()
    {
        int[,] array = new int[5,5];
        array[2,2] = 1;
        int i = 0;
        foreach (int value in array)
        {
            Console.Write(value);

            i++;

            if (i % 5 == 0)
            {
                Console.Write("\n");
            } else
            {
                Console.Write(" ");
            }
        }
    }
}