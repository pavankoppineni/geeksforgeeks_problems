using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.ArrayProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-increasing-subarray/
    /// </summary>
    public class LongestIncreasingSubArray_V1
    {
        public int FindLongestIncreasingSubArray(int[] values)
        {
            var currentMaxLength = 1;
            var maxLength = 1;
            for (var index = 1; index < values.Length; index++)
            {
                var value = values[index];

                //Case 1 : When value is greater than previous value
                if (value >= values[index - 1])
                {
                    currentMaxLength += 1;
                }
                //Case 2 : When value is less than previous value
                else
                {
                    currentMaxLength = 1;
                }
                if (currentMaxLength > maxLength)
                {
                    maxLength = currentMaxLength;
                }
            }
            return maxLength;
        }
    }
}
