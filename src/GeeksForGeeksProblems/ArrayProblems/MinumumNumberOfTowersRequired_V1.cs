using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.ArrayProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/minimum-number-of-towers-required-such-that-every-house-is-in-the-range-of-at-least-one-tower/
    /// </summary>
    public class MinumumNumberOfTowersRequired_V1
    {
        public int FindMinimum(int[] values, int range)
        {
            Array.Sort(values);
            var i = 0;
            var towersCount = 0;
            while (i < values.Length)
            {
                towersCount += 1;
                var number = values[i] + range;

                var mid = FindIndex(values, number, i, values.Length - 1, i);
                number = values[mid] + range;
                var lastElement = FindIndex(values, number, mid, values.Length - 1, mid);
                i = lastElement + 1;
            }

            return towersCount;
        }

        private int FindIndex(int[] values, int number, int start, int end, int minIndex)
        {
            if (start > end)
            {
                return minIndex;
            }

            var mid = start + ((end - start) >> 1);

            //Case A : Mid is greater than number
            //Action : Search left side of array
            if (values[mid] > number)
            {
                return FindIndex(values, number, start, mid - 1, minIndex);
            }

            //Case B : Mid is less than number
            //Action : Search right side of array
            if (values[mid] < number)
            {
                return FindIndex(values, number, mid + 1, end, mid);
            }

            return mid;
        }
    }
}
