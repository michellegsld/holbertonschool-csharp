using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

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
        public void Test_MaxAtEnd()
        {
            List<int> testList = new List<int>() { 0, 1, 2, 3, 4 };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, 4);
        }

        [Test]
        public void Test_MaxAtFront()
        {
            List<int> testList = new List<int>() { 4, 3, 2, 1, 0 };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, 4);
        }

        [Test]
        public void Test_MaxInMiddle()
        {
            List<int> testList = new List<int>() { 0, 1, 2, 1, 0 };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, 2);
        }

        [Test]
        public void Test_MaxIsZero()
        {
            List<int> testList = new List<int>() { 0, -1, -2, -3, -4 };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, 0);
        }

        [Test]
        public void Test_MaxIsNegative()
        {
            List<int> testList = new List<int>() { -1, -2, -3, -4, -5 };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, -1);
        }

        [Test]
        public void Test_ListIsEmpty()
        {
            List<int> testList = new List<int>() { };
            int testMax = Operations.Max(testList);
            Assert.AreEqual(testMax, 0);
        }
    }
}
