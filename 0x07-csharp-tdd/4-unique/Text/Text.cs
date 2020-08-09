using System;

namespace Text
{
    /// <summary>
    /// A public class with one public method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// A public method that returns the first non-repeating character's index.
        /// </summary>
        /// <param name="s">The string to find the character in.</param>
        /// <returns>The index of the first non-repeating character or -1.</returns>
        public static int UniqueChar(string s)
        {
            // Wouldn't go into this for-loop if length of string was 0
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                        {
                            break;
                        }
                        else if (j == s.Length - 1 && s[i] != s[j])
                        {
                            return (i);
                        }
                    }
                    else if (i == s.Length - 1)
                    {
                        return (i);
                    }
                }
            }

            // Either no unique char was found or string was empty
            return (-1);
        }
    }
}
