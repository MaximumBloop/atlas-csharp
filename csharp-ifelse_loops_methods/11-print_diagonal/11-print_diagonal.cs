using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            string str = "";
            for (int j = 0; j < i; j++)
            {
                str += ' ';
            }
            Console.WriteLine("{0}\\", str);
        }
        Console.Write("\n");
    }
}