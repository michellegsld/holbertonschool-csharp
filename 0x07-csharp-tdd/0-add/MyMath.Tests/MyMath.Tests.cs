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
        public void Test_AddPositives()
        {
            int result = Operations.Add(1, 2);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Test_AddNegatives()
        {
            int result = Operations.Add(-1, -2);
            Assert.AreEqual(result, -3);
        }

        [Test]
        public void Test_AddZeros()
        {
            int result = Operations.Add(0, 0);
            Assert.AreEqual(result, 0);
        }
    }
}
