using System;
using System.Linq;
using System.Text.RegularExpressions;

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
                return (true);

            s = s.ToLower();

            s = Regex.Replace(s, "[^a-zA-Z]", "");

            char[] sArray = s.ToCharArray();
            Array.Reverse(sArray);

            if (s == new string(sArray))
                return (true);

            return (false);
        }
    }
}
