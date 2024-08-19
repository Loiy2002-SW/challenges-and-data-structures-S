﻿namespace SecondMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            try
            {
                int secondMax = Btree.FindSecondMax();
                Console.WriteLine($"Second Maximum Value: {secondMax}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
