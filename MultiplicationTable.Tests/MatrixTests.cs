using NUnit.Framework;

namespace MultiplicationTable.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        private int[] primeNumbers;
        private Matrix matrix;

        [SetUp]
        public void Setup()
        {
            primeNumbers = new int[] { 2, 3, 5 };
            matrix = new Matrix(primeNumbers);
        }

        [Test]
        public void CheckIfConstructorWorkProperly()
        {
            matrix = new Matrix(primeNumbers);

            var expectedResult = new int[] { 2, 3, 5 };
            var actualResult = primeNumbers;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfConstructorSetNumberCorrectly()
        {
            matrix = new Matrix(primeNumbers);

            var expectedResult = 3;
            var actualResult = primeNumbers.Length;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ArrayShouldBeSetCorrectly()
        {
            var actualResult = new Matrix(primeNumbers);

            int[][] expectedArr = new int[4][];
            expectedArr[0] = new int[3] { 2, 3, 5 };
            expectedArr[1] = new int[4] { 2, 4, 6, 10 };
            expectedArr[2] = new int[4] { 3, 6, 9, 15 };
            expectedArr[3] = new int[4] { 5, 10, 15, 25 };

            expectedArr.Equals(actualResult);
        }

        [Test]
        public void PrintMatrixDoesNotThrowExc()
        {
            Assert.DoesNotThrow(() => matrix.PrintMatrix());
        }

    }
}
