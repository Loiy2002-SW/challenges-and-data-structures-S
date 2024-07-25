namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stack example
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);
            stack.PrintStack(); // Output: 5 10

            int popped = stack.Pop();
            Console.WriteLine("Popped: " + popped); // Output: Popped: 5

            int peeked = stack.Peek();
            Console.WriteLine("Peeked: " + peeked); // Output: Peeked: 10

            bool isStackEmpty = stack.IsEmpty();
            Console.WriteLine("Is stack empty: " + isStackEmpty); // Output: Is stack empty: False

            // Queue example
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.PrintQueue(); // Output: 10 5

            int dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued); // Output: Dequeued: 10

            int queuePeeked = queue.Peek();
            Console.WriteLine("Peeked: " + queuePeeked); // Output: Peeked: 5

            bool isQueueEmpty = queue.IsEmpty();
            Console.WriteLine("Is queue empty: " + isQueueEmpty); // Output: Is queue empty: False
        }
    }
}
