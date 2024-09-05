using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            for (int i = 0; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (str.Length > 0)
                    {
                        str += ", ";
                    }
                    str += String.Format("{0}{1}", i, j);
                }
            }
            Console.WriteLine(str);
        }
    }
}
