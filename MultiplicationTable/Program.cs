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

            var result = new Matrix(primeNumbers);
            result.PrintMatrix();
        }
    }
}
