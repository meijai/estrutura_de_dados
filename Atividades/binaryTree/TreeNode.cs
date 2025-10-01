using System.Globalization;

namespace binaryTree
{
    public class TreeNode<T>
    {
        public required T Data { get; set; }
        public required TreeNode<T> Parent { get; set; }
        public required List<TreeNode<T>> Children { get; set; }
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}