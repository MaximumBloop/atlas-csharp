using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1";
            for (int i = 2; i <= 100; i++)
            {
                str += ' ';
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        str += "Fizz";
                    }
                    if (i % 5 == 0)
                    {
                        str += "Buzz";
                    }
                } else
                {
                    str += i.ToString();
                }
            }
            Console.WriteLine(str);
        }
    }
}
