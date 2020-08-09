using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// A public class with one public method.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// A public method that returns the max integer in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers.</param>
        /// <returns>The max integer in the list.</returns>
        public static int Max(List<int> nums)
        {
            int maxInt;

            if (nums.Count == 0)
                return (0);
            else
                maxInt = nums[0];

            foreach (int num in nums)
                if (num > maxInt)
                    maxInt = num;

            return (maxInt);
        }
    }
}
