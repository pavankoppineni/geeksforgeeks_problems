using GeeksForGeeksProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.Tests.ArrayProblems
{
    [TestClass]
    public class MinumumNumberOfTowersRequired_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumNumberOfTowers_Then_ShouldReturnMaximumNumberOfTowers()
        {
            //Given
            var values = new int[] { 7, 2, 4, 6, 5, 9, 12, 11 };
            var problem = new MinumumNumberOfTowersRequired_V1();
            var expectedvalue = 3;
            var range = 2;

            //When
            var actualValue = problem.FindMinimum(values, range);

            //Then
            Assert.AreEqual(expectedvalue, actualValue);
        }
    }
}
