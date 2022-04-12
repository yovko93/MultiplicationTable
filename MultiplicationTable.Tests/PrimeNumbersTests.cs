using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace MultiplicationTable.Tests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        private PrimeNumbers primeNumbers;

        [SetUp]
        public void Setup()
        {
            primeNumbers = new PrimeNumbers();
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Assert.That(new PrimeNumbers(), Is.Not.Null);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void ShouldThrowEmptyList(int n)
        {
            var expectedResult = new List<int>() { };
            var actualResult = primeNumbers.GetFirstNPrimeNumbers(n);

            expectedResult.Equals(actualResult);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void GetFirstNPrimeNumbersShouldWorkProperly(int n)
        {
            var actualResult = primeNumbers.GetFirstNPrimeNumbers(n);

            Assert.That(actualResult, Is.Not.Null);
        }

        [Test]
        public void GetFirstNPrimeNumbersShouldReturnList()
        {
            var expectedResult = new List<int>() { 2, 3, 5, 7 };
            var actualResult = primeNumbers.GetFirstNPrimeNumbers(4);

            expectedResult.Equals(actualResult);
        }

        [Test]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(11)]
        [TestCase(17)]
        public void CheckPrimeNumberShouldReturnTrue(int number)
        {
            MethodInfo method = primeNumbers.GetType().GetMethod("CheckPrimeNumber", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] parms = new object[1] { number };

            var checkPrimeNumber = method.Invoke(primeNumbers, parms);

            Assert.That(checkPrimeNumber, Is.True);
        }

        [Test]
        [TestCase(4)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(24)]
        public void CheckPrimeNumberShouldReturnFalse(int number)
        {
            MethodInfo method = primeNumbers.GetType().GetMethod("CheckPrimeNumber", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] parms = new object[1] { number };

            var checkPrimeNumber = method.Invoke(primeNumbers, parms);

            Assert.That(checkPrimeNumber, Is.False);
        }

        [Test]
        [TestCase(5)]
        public void FindNextPrimeNumberShouldWorkProperly(int number)
        {
            MethodInfo method = primeNumbers.GetType().GetMethod("FindNextPrimeNumber", BindingFlags.NonPublic | BindingFlags.Instance);

            object[] parms = new object[1] { number };

            var findNextPrimeNumber = method.Invoke(primeNumbers, parms);

            int expectedResult = 7;

            Assert.That(findNextPrimeNumber, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetRemainingPrimeNumbersShouldReturnAsInput()
        {
            MethodInfo method = primeNumbers.GetType().GetMethod("GetRemainingPrimeNumbers", BindingFlags.NonPublic | BindingFlags.Instance);

            int number = 0;
            var listOfNumbers = new List<int>() { 2, 3 };

            object[] parms = new object[2] { number, listOfNumbers };

            var remainingPrimeNums = method.Invoke(primeNumbers, parms);
            var expectedResult = new List<int>() { 2, 3 };

            expectedResult.Equals(remainingPrimeNums);
        }
    }
}
