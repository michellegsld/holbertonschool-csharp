using NUnit.Framework;

namespace MyMath.Tests
{
    [TextClass]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod]
        public void Test_AddPositives()
        {
            result = Add(1, 2);
            Assert.AreEqual(result, 3);
        }

        public void Test_AddNegatives()
        {
            result = Add(-1, -2);
            Assert.AreEqual(result, -3);
        }

        public void Test_AddZeros()
        {
            result = Add(0, 0);
            Assert.AreEqual(result, 0);
        }
    }
}