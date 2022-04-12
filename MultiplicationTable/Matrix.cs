using System;

namespace MultiplicationTable
{
    public class Matrix
    {
        private int[] primeNumbers;
        private int number;

        public Matrix(int[] primeNumbers)
        {
            this.primeNumbers = primeNumbers;
            this.number = primeNumbers.Length;
        }

        public void PrintMatrix()
        {
            int[,] matrix = new int[number + 1, number + 1];

            ReturnMatrix(matrix);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine("\n");

                if (row == 0)
                {
                    Console.Write("  ");

                    for (int col = 1; col < matrix.GetLength(1); col++)
                    {
                        Console.Write($"{matrix[row, col]}  ");
                    }

                    continue;
                }

                Console.Write($"{matrix[row, 0]} ");

                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}  ");
                }

            }
        }

        private int[,] ReturnMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row == 0)
                {
                    for (int col = 1; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = primeNumbers[col - 1];
                    }

                    continue;
                }

                matrix[row, 0] = primeNumbers[row - 1];

                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrix[row, 0] * primeNumbers[col - 1];
                }
            }

            return matrix;
        }
    }
}
