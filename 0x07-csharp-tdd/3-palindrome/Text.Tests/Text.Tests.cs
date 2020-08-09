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
        public void Test_LowercasePalindromeTrue()
        {
            string word = new String("hannah");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }

        [Test]
        public void Test_LowercasePalindromeFalse()
        {
            string word = new String("handyhannah");
            bool answer = Str.IsPalindrome(word);
            Assert.IsFalse(answer);
        }

        [Test]
        public void Test_AlternatingCapsPalindromeTrue()
        {
            string word = new String("hAnNaH");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }

        [Test]
        public void Test_SpacesPalindromeTrue()
        {
            string word = new String("h  a       n n a   h");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }

        [Test]
        public void Test_PunctuationPalindromeTrue()
        {
            string word = new String("hAnNaH, raceCaR:   >hannah");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }

        [Test]
        public void Test_EmptyPalindromeTrue()
        {
            string word = new String("");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }

        [Test]
        public void Test_EmptyPunctuationPalindromeTrue()
        {
            string word = new String("  ,,  ; , ; ; .. /? / ;** ");
            bool answer = Str.IsPalindrome(word);
            Assert.IsTrue(answer);
        }
    }
}