using System;

namespace Text
{
    /// <summary>
    /// A public class with one public method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// A public method that checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">the string to check.</param>
        /// <returns>True if a palindrome or False if not.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return (True);

            var stringLetters = new String((s.ToLower()).Where(Char.IsLetter).ToArray());

            if (stringLetters == stringLetters.Reverse())
                return (True);

            return (False);
        }
    }
}
