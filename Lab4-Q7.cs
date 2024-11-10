using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];
        int[,] resultMatrix = new int[3, 3];

        Console.WriteLine("Enter elements of Matrix A (3x3):");
        InputMatrix(matrixA);

        Console.WriteLine("Enter elements of Matrix B (3x3):");
        InputMatrix(matrixB);

        MultiplyMatrices(matrixA, matrixB, resultMatrix);

        Console.WriteLine("Resultant Matrix after Multiplication:");
        PrintMatrix(resultMatrix);
    }

    static void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void MultiplyMatrices(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

