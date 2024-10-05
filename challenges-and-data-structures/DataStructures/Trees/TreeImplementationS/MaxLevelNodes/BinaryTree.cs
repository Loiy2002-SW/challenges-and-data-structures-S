using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLevelNodes
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxNodes = 0;
            int maxLevel = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelNodes = queue.Count; // number of nodes at the current level

                if (levelNodes > maxNodes)
                {
                    maxNodes = levelNodes;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelNodes; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }
    }
}
