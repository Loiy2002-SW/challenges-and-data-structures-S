using System;
using Xunit;

namespace MaxLevelNodes
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void Test_FindMaxLevelNodes_ExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result);  // Level 2 has the maximum number of nodes
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleLevelsWithMaxNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); // Level 2 has 3 nodes, which is the maximum
        }

        [Fact]
        public void Test_FindMaxLevelNodes_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindMaxLevelNodes());
        }

        [Fact]
        public void Test_FindMaxLevelNodes_SingleNode()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(0, result); // Level 0 has 1 node (root)
        }
    }
}
