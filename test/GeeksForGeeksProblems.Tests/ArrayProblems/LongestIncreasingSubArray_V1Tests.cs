using GeeksForGeeksProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LongestIncreasingSubArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindMaxIncreasingSubArray_Then_ShouldReturnMaxSubArray()
        {
            //Given
            var values = new int[] { 4, 1, 2, 3 };
            var problem = new LongestIncreasingSubArray_V1();
            var expectedValue = 3;

            //When
            var actualValue = problem.FindLongestIncreasingSubArray(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
