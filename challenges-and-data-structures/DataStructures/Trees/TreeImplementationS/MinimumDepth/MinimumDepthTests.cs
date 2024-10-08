using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MinimumDepth
{

    public class MinimumDepthTests
    {
        [Fact]
        public void Test_MultipleNodes_VaryingDepths()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth);
        }

        [Fact]
        public void Test_EmptyTree_ReturnsZero()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth);
        }

        [Fact]
        public void Test_LeafNodeAtDepthThree_ReturnsThree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(3, minDepth);
        }
    }

}
