namespace LeafSum
{
    public class BinaryTreeTests
    {
        [Fact]
        public void SumOfLeafNodes_ShouldReturnCorrectSum()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(4);

            int leafSum = Btree.SumOfLeafNodes();
            Assert.Equal(51, leafSum);
        }

        [Fact]
        public void SumOfLeafNodes_WithNegativeLeafValues_ShouldReturnCorrectSum()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(9);
            Btree.Root.Left = new Node(-8);
            Btree.Root.Right = new Node(12);
            Btree.Root.Left.Left = new Node(-3);
            Btree.Root.Left.Right = new Node(-7);
            Btree.Root.Right.Left = new Node(17);
            Btree.Root.Right.Right = new Node(23);
            Btree.Root.Left.Left.Right = new Node(-4);

            int leafSum = Btree.SumOfLeafNodes();
            Assert.Equal(29, leafSum);
        }
    }

}
