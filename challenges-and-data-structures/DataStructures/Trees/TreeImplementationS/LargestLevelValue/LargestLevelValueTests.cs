

namespace LargestLevelValue
{
    internal class LargestLevelValueTests
    {
            [Fact]
            public void TestLargestLevelValue()
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

                Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
                Assert.Equal(49, GetSumOfLargestValues(largestValues));
            }

            private int GetSumOfLargestValues(List<int> largestValues)
            {
                int sum = 0;
                foreach (int value in largestValues)
                {
                    sum += value;
                }
                return sum;
            }
        
    }
}
