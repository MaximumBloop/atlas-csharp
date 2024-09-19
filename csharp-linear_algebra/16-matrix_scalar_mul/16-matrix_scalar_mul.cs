using System;
class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
        {
            return new double[,] { { -1} };
        }
        
        double [,] result = new double[matrix.GetLength(0),matrix.GetLength(1)];
        Array.Copy(matrix, result, matrix.Length);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i,j] *= scalar;
            }
        }

        return result;
    }
}
