


using StackAndQueue;

namespace challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack
    {
        static void Main(string[] args)
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("Ex 1:");
            Console.WriteLine(stack);

            stack.ReverseStack();
            Console.WriteLine("After Reveresed: ");
            Console.WriteLine(stack); 

            stack.Push(6);
            stack.Push(7);
            Console.WriteLine("====================================================");
            Console.WriteLine("Ex 2:");
            Console.WriteLine(stack); 

            stack.ReverseStack();
            Console.WriteLine("After Reveresed: ");
            Console.WriteLine(stack);
            Console.ReadKey();


        }


            public void ReverseStack()
        {
            if (IsEmpty()) return;

            Queue queue = new Queue();

            while (!IsEmpty())
                queue.Enqueue(Pop());

            while (!queue.IsEmpty())
                Push(queue.Dequeue());
        }

        public override string ToString()
        {
            Node current = top;
            string result = "Stack: Top -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "null";
            return result;
        }
    }
}
