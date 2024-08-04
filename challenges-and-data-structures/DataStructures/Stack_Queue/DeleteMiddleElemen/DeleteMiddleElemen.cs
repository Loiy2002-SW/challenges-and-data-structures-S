


using StackAndQueue;

namespace challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue
{
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            Node current = top;
            if (current == null) return; // Stack is empty

            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            int middleIndex = (count % 2 == 0) ? count / 2 - 1 : count / 2;
            if (middleIndex == 0)
            {
                Pop(); // Remove the top element if it's the only one
                return;
            }

            current = top;
            for (int i = 0; i < middleIndex - 1; i++)
                current = current.Next;

            // Remove the middle element
            if (current != null && current.Next != null)
                current.Next = current.Next.Next;
        }
    }
}
