using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksProblems.TreeProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/print-nodes-dont-sibling-binary-tree/
    /// </summary>
    public class PrintAllNodesWithNoSibling_V1
    {
        public IList<int> CountNodesWitoutSibling(Node node)
        {
            var nodes = new List<int>();
            CountNodesWitoutSibling(node, nodes);
            return nodes;
        }

        private void CountNodesWitoutSibling(Node node, IList<int> nodes)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left == null && node.Right != null)
            {
                nodes.Add(node.Right.Value);
            }
            else if (node.Left != null && node.Right == null)
            {
                nodes.Add(node.Left.Value);
            }
            CountNodesWitoutSibling(node.Left, nodes);
            CountNodesWitoutSibling(node.Right, nodes);
        }
    }
}
