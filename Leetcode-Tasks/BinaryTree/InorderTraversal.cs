using System;
using System.Collections.Generic;

namespace Leetcode_Tasks.BinaryTree
{
    public class InorderTraversal
    {
        public static IList<int> Traversal(TreeNode root)
        {
            var result = new List<int>();
            var treeStack = new Stack<TreeNode>();
            var currentNode = root;
            while (currentNode != null || treeStack.Count > 0)
            {
                while (currentNode != null)
                {
                    treeStack.Push(currentNode);
                    currentNode = currentNode.left;
                }
                currentNode = treeStack.Pop();
                result.Add(currentNode.val);
                currentNode = currentNode.right;
            }

            return result;
        }
    }
}

