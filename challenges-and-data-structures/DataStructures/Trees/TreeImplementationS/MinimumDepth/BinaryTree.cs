using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDepth
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public int FindMinimumDepth()
        {
            if (Root == null) return 0;

            Queue<(Node, int)> queue = new Queue<(Node, int)>();
            queue.Enqueue((Root, 1));

            while (queue.Count > 0)
            {
                (Node current, int depth) = queue.Dequeue();

                // If this is a leaf node
                if (current.Left == null && current.Right == null)
                {
                    return depth;
                }

                // Continue to add children to the queue
                if (current.Left != null)
                {
                    queue.Enqueue((current.Left, depth + 1));
                }
                if (current.Right != null)
                {
                    queue.Enqueue((current.Right, depth + 1));
                }
            }

            return 0; // Default case (shouldn't reach here)
        }
    }
}
