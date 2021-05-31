using GeeksForGeeksProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.Tests.TreeProblems
{
    [TestClass]
    public class PrintAllNodesWithNoSibling_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_CountNodesWitoutSibling_Then_ShouldReturnCountOfNodesWithoutSibling()
        {
            //Given
            var node_11 = CreateNode(1);

            var node_21 = CreateNode(2);
            var node_22 = CreateNode(3);
            node_11.Left = node_21;
            node_11.Right = node_22;

            var node_31 = CreateNode(4);
            node_21.Left = node_31;

            var node_33 = CreateNode(5);
            node_22.Left = node_33;

            var problem = new PrintAllNodesWithNoSibling_V1();
            var expectedValues = new List<int>
            {
                4,
                5
            };

            //When
            var actualValues = problem.CountNodesWitoutSibling(node_11);

            //Then
            Assert.AreEqual(expectedValues.Count, actualValues.Count);
            for (var index = 0; index < expectedValues.Count; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }

        private static Node CreateNode(int value)
        {
            return new Node { Value = value };
        }
    }
}
