﻿using TreeImplementation;

namespace challenges_and_data_structures.DataStructures.Trees.TreeImplementationS.MirrorTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeMirror Btree = new BinaryTreeMirror();
            Btree.Root = new TNode(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);

            List<int> originalInorder = Btree.InorderTraversal(); // Output: [12, 8, 9, 4, 7]
            Console.WriteLine(string.Join(", ", originalInorder));

            Btree.MirrorTree();

            List<int> mirroredInorder = Btree.InorderTraversal(); // Output: [7, 4, 9, 8, 12]
            Console.WriteLine(string.Join(", ", mirroredInorder));
        }
    }
}
