using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char character in "abcdefghijklmnopqrstuvwxyz")
            {
                if (character != 'q' && character != 'e')
                {
                    Console.Write(character);
                }
            }
        }
    }
}
