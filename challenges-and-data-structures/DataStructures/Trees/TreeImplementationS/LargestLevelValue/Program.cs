﻿namespace LargestLevelValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            List<int> largestValues = Btree.LargestLevelValue();
            Console.WriteLine("Largest values at each level:");
            Console.WriteLine(string.Join(", ", largestValues)); // Output: 5, 13, 20, 11
        }
    }
}
