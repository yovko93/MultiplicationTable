using NUnit.Framework;
using System.Collections.Generic;

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
        public void GetFirstNPrimeNumbersShouldReturnOneElement()
        {
            var actualResult = primeNumbers.GetFirstNPrimeNumbers(1);
            var expectedResult = new List<int>() { 2 };

            expectedResult.Equals(actualResult);
        }

        [Test]
        public void GetFirstNPrimeNumbersShouldReturnList()
        {
            var expectedResult = new List<int>() { 2, 3, 5, 7 };
            var actualResult = primeNumbers.GetFirstNPrimeNumbers(4);

            expectedResult.Equals(actualResult);
        }
    }
}
