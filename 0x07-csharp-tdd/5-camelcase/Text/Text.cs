using System;

namespace Text
{
    /// <summary>
    /// A public class containing one public method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// A method that determines how many words are in a string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>Number of words in s.</returns>
        public static int CamelCase(string s)
        {
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || Char.IsUpper(s[i]))
                    total++;
            }

            return (total);
        }
    }
}
