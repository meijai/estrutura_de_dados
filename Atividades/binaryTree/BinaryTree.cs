using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace binaryTree
{
    public class BinaryTree<T>
    {
        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTORDER
        }
        public BinaryTreeNode<T> Root { get; set; } = null!;
        public int Count { get; set; }

        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, nodes);
            }
        }
    }
}