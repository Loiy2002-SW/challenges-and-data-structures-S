

using StackAndQueue;

namespace challenges_and_data_structures.DataStructures.Stack_Queue.MinStack
{
    public class MinStack : Stack
    {
        private Stack minStack;

        public MinStack()
        {
            minStack = new Stack();
        }
        public new void Push(int x)
        {
            base.Push(x);
            if (minStack.IsEmpty() || x <= minStack.Peek())
                minStack.Push(x);
        }
        public new int Pop()
        {
            int top = base.Pop();
            if (top == minStack.Peek())
                minStack.Pop();
            return top;
        }
        public int Top()
        {
            return base.Peek();
        }
        public bool IsEmpty()
        {
        return base.IsEmpty(); 
        }
        public void PrintStack()
        {
            base.PrintStack();
        }
        public int GetMin()
        {
            if (minStack.IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            return minStack.Peek();
        }
    }
}
