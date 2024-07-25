

namespace StackAndQueueTests
{
    using StackAndQueue;
    using Xunit;

    public class StackTests
    {
        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);
            int popped = stack.Pop();
            Assert.Equal(5, popped);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestIsEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
            stack.Push(10);
            Assert.False(stack.IsEmpty());
            stack.Pop();
            Assert.True(stack.IsEmpty());
        }
    }

    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);
            int dequeued = queue.Dequeue();
            Assert.Equal(10, dequeued);
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void TestIsEmpty()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
        }
    }

}