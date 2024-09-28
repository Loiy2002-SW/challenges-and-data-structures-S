﻿namespace RightViewPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            Btree.PrintRightView();  // Expected output: 2 5 6 7
        }
    }
}
