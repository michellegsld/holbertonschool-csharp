using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TextFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AddPositives()
        {
            result = Add(1, 2);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Test_AddNegatives()
        {
            result = Add(-1, -2);
            Assert.AreEqual(result, -3);
        }

        [Test]
        public void Test_AddZeros()
        {
            result = Add(0, 0);
            Assert.AreEqual(result, 0);
        }
    }
}
