namespace LeafSum
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            // If node is a leaf
            if (node.Left == null && node.Right == null)
                return node.Value;

            // Recursively sum leaf nodes from left and right subtrees
            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }
    }
}
