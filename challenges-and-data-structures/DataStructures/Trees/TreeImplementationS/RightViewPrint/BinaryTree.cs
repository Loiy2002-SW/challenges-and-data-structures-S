using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightViewPrint
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelCount = queue.Count;

                for (int i = 0; i < levelCount; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // If this is the rightmost node of the current level
                    if (i == levelCount - 1)
                        Console.Write(currentNode.Data + " ");

                    // Enqueue left and right children
                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }
            }
            Console.WriteLine();
        }
    }
}
