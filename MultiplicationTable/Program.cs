using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var primeNumbers = new PrimeNumbers()
                .GetFirstNPrimeNumbers(number)
                .ToArray();

            int[,] matrix = new int[number + 1, number + 1];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine("\n");

                if (row == 0)
                {
                    Console.Write("  ");

                    for (int col = 1; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = primeNumbers[col - 1];
                        Console.Write($"{matrix[row, col]}  ");
                    }

                    continue;
                }

                matrix[row, 0] = primeNumbers[row - 1];
                Console.Write($"{matrix[row, 0]} ");

                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    matrix[row - 1, col] = primeNumbers[row - 1] * primeNumbers[col - 1];
                    Console.Write($"{matrix[row - 1, col]}  ");
                }

            }
        }
    }
}
