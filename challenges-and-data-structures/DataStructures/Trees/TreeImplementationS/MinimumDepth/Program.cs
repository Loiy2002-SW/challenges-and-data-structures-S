namespace MinimumDepth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            Console.WriteLine(Btree.FindMinimumDepth()); // Output: 2

            Btree.Root.Left.Right = null;
            Btree.Root.Right.Right = new Node(6);

            Console.WriteLine(Btree.FindMinimumDepth()); // Output: 3
        }
    }
}
