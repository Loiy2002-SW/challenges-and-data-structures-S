

using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestPreOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var output = new List<int>();
            void CaptureOutput(int data) => output.Add(data);
            tree.PreOrder(tree.Root, CaptureOutput);

            Assert.Equal(new[] { 1, 2, 3 }, output);
        }

        [Fact]
        public void TestInOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var output = new List<int>();
            void CaptureOutput(int data) => output.Add(data);
            tree.InOrder(tree.Root, CaptureOutput);

            Assert.Equal(new[] { 2, 1, 3 }, output);
        }

        [Fact]
        public void TestPostOrder()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            var output = new List<int>();
            void CaptureOutput(int data) => output.Add(data);
            tree.PostOrder(tree.Root, CaptureOutput);

            Assert.Equal(new[] { 2, 3, 1 }, output);
        }
    }
}
