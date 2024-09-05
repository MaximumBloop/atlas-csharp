using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last = number;
        if (last < 0)
        {
            last *= -1;
        }
        string str = "The last digit of " + number + " ";
	    while (last >= 10)
        {
            last = last % 10;
        }
        if (number < 0)
        {
            last *= -1;
        }
        str += "is " + last + " ";
        if (last >= 5)
        {
            str += "and is greater than 5";
        } else if (number == 0)
        {
            str += "and is 0";
        } else if (number < 6)
        {
            str += "and is less than 6 and not 0";
        }
        Console.WriteLine(str);
    }
}