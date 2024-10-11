using System;
using Xunit;

namespace BTreeToBTS
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Test_ConvertToBST_Example()
        {
            // Setup the binary tree as per the example
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(40);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(50);
            Btree.Root.Left.Left = new Node(5);
            Btree.Root.Left.Right = new Node(30);
            Btree.Root.Right.Right = new Node(60);
            Btree.Root.Left.Right.Left = new Node(20);
            Btree.Root.Left.Right.Right = new Node(35);

            // Before Conversion
            PrintTree(Btree.Root);

            // Convert to BST
            Btree.ConvertToBST();

            // After Conversion (Expect a BST structure)
            PrintTree(Btree.Root);
        }

        private void PrintTree(Node node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + "+- " + node.Value);
                indent += last ? "   " : "|  ";

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }

        [Fact]
        public void Test_ConvertToBST_OneSided()
        {
            // Test with a tree having nodes only on one side
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Right = new Node(20);
            Btree.Root.Right.Right = new Node(30);

            Btree.ConvertToBST();
            PrintTree(Btree.Root);
        }
    }
}
