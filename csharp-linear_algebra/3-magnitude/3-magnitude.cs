using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double result = 0;

        foreach (double i in vector)
        {
            result += i * i;
        }

        return Math.Round(Math.Sqrt(result), 2);
    }
}