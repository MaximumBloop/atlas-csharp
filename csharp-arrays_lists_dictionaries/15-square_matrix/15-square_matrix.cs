using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] copy = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];

        for (int i = 0; i < copy.GetLength(0); i++)
        {
            for (int j = 0; j < copy.GetLength(1); j++)
            {
                copy[i,j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return copy;
    }
}