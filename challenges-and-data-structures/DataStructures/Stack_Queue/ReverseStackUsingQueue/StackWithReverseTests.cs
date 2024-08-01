

using challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue;

namespace ChallengesTests
{
    public class StackWithReverseTests
    {
        [Fact]
        public void ReverseStack_MultipleElements()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ReverseStack();
            Assert.Equal("Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5", stack.ToString());
        }

        [Fact]
        public void ReverseStack_SingleElement()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();
            Assert.Equal("Stack: Top -> 1", stack.ToString());
        }

        [Fact]
        public void ReverseStack_EmptyStack()
        {
            StackWithReverse stack = new StackWithReverse();

            stack.ReverseStack();
            Assert.Equal("Stack: Top -> ", stack.ToString());
        }
    }
}