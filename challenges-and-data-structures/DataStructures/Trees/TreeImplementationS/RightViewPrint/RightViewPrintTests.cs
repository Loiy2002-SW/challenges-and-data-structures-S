using System;
using Xunit;

namespace RightViewPrint
{
    public class RightViewTests
    {
        [Fact]
        public void Test_PrintRightView_ExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Act and Assert
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Btree.PrintRightView();
                var result = sw.ToString().Trim();
                Assert.Equal("2 5 6 7", result);
            }
        }

        [Fact]
        public void Test_PrintRightView_RightSideOnly()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Right = new Node(3);
            Btree.Root.Right.Right.Right = new Node(4);

            // Act and Assert
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Btree.PrintRightView();
                var result = sw.ToString().Trim();
                Assert.Equal("1 2 3 4", result);
            }
        }

        [Fact]
        public void Test_PrintRightView_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act and Assert
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Btree.PrintRightView();
                var result = sw.ToString().Trim();
                Assert.Equal("The tree is empty.", result);
            }
        }

        [Fact]
        public void Test_PrintRightView_OneNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);

            // Act and Assert
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Btree.PrintRightView();
                var result = sw.ToString().Trim();
                Assert.Equal("10", result);
            }
        }
    }
}
