using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeToBTS
{
    public class BinaryTree
    {
        public Node Root;

        public void ConvertToBST()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is empty.");

            // Step 1: Store the values in a list
            List<int> values = new List<int>();
            InOrderTraversal(Root, values);

            // Step 2: Sort the values
            values.Sort();

            // Step 3: Assign sorted values back to the tree
            AssignValues(Root, values.GetEnumerator());
        }

        private void InOrderTraversal(Node node, List<int> values)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, values);
            values.Add(node.Value);
            InOrderTraversal(node.Right, values);
        }

        private void AssignValues(Node node, IEnumerator<int> enumerator)
        {
            if (node == null) return;

            AssignValues(node.Left, enumerator);

            // Step 4: Assign the next value from the sorted list
            if (enumerator.MoveNext())
            {
                node.Value = enumerator.Current;
            }

            AssignValues(node.Right, enumerator);
        }

        public void PrintTree(Node node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + "+- " + node.Value);
                indent += last ? "   " : "|  ";

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }
    }

}
