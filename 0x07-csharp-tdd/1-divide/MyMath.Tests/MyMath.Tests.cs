using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_RegMatRegDiv()
        {
            int[,] input = new int[,] { { 6, 92, 0 }, { 14, -95, 15 }, { -140, -7, -20 } };
            int[,] output = Matrix.Divide(input, 2);
            int[,] compare = new int[,] { { 3, 46, 0 }, { 7, -47, 7 }, { -70, -3, -10 } };
            Assert.AreEqual(output, compare);
        }

        [Test]
        public void Test_RegMatNegDiv()
        {
            int[,] input = new int[,] { { 6, 92, 0 }, { 14, -95, 15 }, { -140, -7, -20 } };
            int[,] output = Matrix.Divide(input, -2);
            int[,] compare = new int[,] { { -3, -46, 0 }, { -7, 47, -7 }, { 70, 3, 10 } };
            Assert.AreEqual(output, compare);
        }

        [Test]
        public void Test_RegMatZeroDiv()
        {
            int[,] input = new int[,] { { 6, 92, 0 }, { 14, -95, 15 }, { -140, -7, -20 } };
            int[,] output = Matrix.Divide(input, 0);
            int[,] compare = null;
            Assert.AreEqual(output, compare);
        }

        [Test]
        public void Test_NullMatRegDiv()
        {
            int[,] input = null;
            int[,] output = Matrix.Divide(input, 2);
            int[,] compare = null;
            Assert.AreEqual(output, compare);
        }
    }
}
