using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "00";
            for (int i = 1; i <= 99; i++)
            {
                str += String.Format(", {0:00}", i);
            }
            str += '\n';
            Console.Write(str);
        }
    }
}
