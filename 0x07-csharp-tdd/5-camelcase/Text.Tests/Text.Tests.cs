using NUnit.Framework;
using System;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_OneWord()
        {
            string word = new String("yummy");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 1);
        }

        [Test]
        public void Test_TwoWords()
        {
            string word = new String("yummyFood");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 2);
        }

        [Test]
        public void Test_WholeSentence()
        {
            string word = new String("theBestThingToEatIsYummyFood");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 8);
        }

        [Test]
        public void Test_EmptyString()
        {
            string word = new String("");
            int total = Str.CamelCase(word);
            Assert.AreEqual(total, 0);
        }
    }
}