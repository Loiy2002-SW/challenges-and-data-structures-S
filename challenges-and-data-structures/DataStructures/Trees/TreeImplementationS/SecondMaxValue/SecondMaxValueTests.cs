using Xunit;

namespace SecondMaxValue
{
    public class BinaryTreeTests
    {
        [Fact]
        public void FindSecondMax_ValidTree_ReturnsSecondMax()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            int secondMax = Btree.FindSecondMax();

            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void FindSecondMax_SingleNodeTree_ThrowsException()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);

            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_EmptyTree_ThrowsException()
        {
            BinaryTree Btree = new BinaryTree();

            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_TreeWithNegativeValues_ReturnsSecondMax()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(-10);
            Btree.Root.Left = new Node(-20);
            Btree.Root.Right = new Node(-5);
            Btree.Root.Right.Right = new Node(0);

            int secondMax = Btree.FindSecondMax();

            Assert.Equal(-5, secondMax);
        }

        [Fact]
        public void FindSecondMax_TreeWithDuplicateValues_ReturnsSecondMax()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(10);

            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }
    }

}
