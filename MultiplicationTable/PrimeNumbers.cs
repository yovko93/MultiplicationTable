using System.Collections.Generic;
using System.Linq;

namespace MultiplicationTable
{
    public class PrimeNumbers
    {
        public PrimeNumbers()
        {
        }

        public List<int> GetFirstNPrimeNumbers(int n)
        {
            var numbers = new List<int>();

            if (n <= 0)
            {
                return numbers;
            }

            if (n >= 1)
            {
                numbers.Add(2);
                n--;
            }
            if (n >= 2)
            {
                numbers.Add(3);
                n--;
            }
            if (n >= 3)
            {
                numbers.Add(5);
                n--;
            }

            var result = GetRemainingPrimeNumbers(n, numbers);

            return result;
        }

        private List<int> GetRemainingPrimeNumbers(int n, List<int> numbers)
        {
            if (n == 0)
            {
                return numbers;
            }

            int nextPrimeNumber = FindNextPrimeNumber(numbers.LastOrDefault());
            numbers.Add(nextPrimeNumber);

            return GetRemainingPrimeNumbers(n - 1, numbers);
        }

        // Recieves a number
        // Returns the next prime number after it
        private int FindNextPrimeNumber(int number)
        {
            number++;

            while (!CheckPrimeNumber(number))
            {
                number++;
            }

            return number;
        }

        // Returns true if the number is prime, and false if its not
        private bool CheckPrimeNumber(int number)
        {
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
