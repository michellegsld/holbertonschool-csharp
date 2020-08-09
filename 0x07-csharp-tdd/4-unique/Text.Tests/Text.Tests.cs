using NUnit.Framework;
using Text;
using System;

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
        public void Test_AllRepeats()
        {
            string word = new String("aabbcc");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void Test_NoRepeats()
        {
            string word = new String("abcdef");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 0);
        }

        [Test]
        public void Test_LastCharNotRepeat()
        {
            string word = new String("aabbccd");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 6);
        }

        [Test]
        public void Test_FirstCharNotRepeat()
        {
            string word = new String("abbccdd");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 0);
        }

        [Test]
        public void Test_MidCharNotRepeat()
        {
            string word = new String("aabbcddee");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 4);
        }

        [Test]
        public void Test_EmptyString()
        {
            string word = new String("");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void Test_WordRepeat()
        {
            string word = new String("catcat");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void Test_DifferentWordsNoRepeat()
        {
            string word = new String("cathat");
            int index = Str.UniqueChar(word);
            Assert.AreEqual(index, 0);
        }
    }
}