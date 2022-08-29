using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4] { {1, 2, 3, 4}, 
                                            {5, 6, 7, 8}, 
                                            {9, 10, 11, 12}, 
                                            {13, 14, 15, 16}};

            PrintMatrix(matrix);
        }

        static [,] RotateMatrix(int[,] matrix)
        {
            int i = 0;
            int j = 0;
            int tmp = 0;
            int limi = matrix.GetLength(0);
            int limj = matrix.GetLength(1);

            for(; i < limi; i++)
            {
                for(; j < limj; j++)
                {
                    tmp = matrix[i, limj - 1];
                    matrix[i, limj - 1] = matrix[i, j];
                    matrix[limi - 1, limj - 1] = tmp;
                }
                i++;
                j++;
                limi--;
                limj--;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i=0; i < matrix.GetLength(0); i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
