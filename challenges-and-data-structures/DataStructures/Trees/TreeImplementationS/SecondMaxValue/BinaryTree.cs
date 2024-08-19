
namespace SecondMaxValue
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public int FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is empty.");

            // Call the helper method to find the maximum and second maximum
            return FindSecondMaxHelper(Root).secondMax;
        }

        private (int max, int secondMax) FindSecondMaxHelper(Node node)
        {
            if (node == null)
                return (int.MinValue, int.MinValue);

            var leftResult = FindSecondMaxHelper(node.Left);
            var rightResult = FindSecondMaxHelper(node.Right);

            // Get the maximum and second maximum from the left and right subtrees
            int max = Math.Max(Math.Max(leftResult.max, rightResult.max), node.Value);
            int secondMax = Math.Min(leftResult.max, rightResult.max);

            // Update the second max considering the current node
            if (node.Value < max)
                secondMax = Math.Max(secondMax, node.Value);

            return (max, secondMax);
        }
    }

}
