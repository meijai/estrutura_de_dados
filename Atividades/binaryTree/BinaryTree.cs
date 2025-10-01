namespace binaryTree
{
    public class BinaryTree<T>
    {
        public required BinaryTreeNode<T> root { get; set; }
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
                    TraversePreOrder(root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(root, nodes);
                    break;
            }
            return nodes;
        }

        public enum TraversalEnum
        {
            PREORDER,
            INORDER,
            POSTORDER
        }

        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node
                in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }
    }
}