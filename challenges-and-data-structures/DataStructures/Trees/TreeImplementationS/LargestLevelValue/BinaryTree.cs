using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestLevelValue
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public List<int> LargestLevelValue()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            List<int> largestValues = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // Find the max value at this level
                    if (currentNode.Value > maxAtLevel)
                    {
                        maxAtLevel = currentNode.Value;
                    }

                    // Add the child nodes to the queue for the next level
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                // Add the largest value at this level to the list
                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }
    }
}
