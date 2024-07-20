namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    // Represents a singly linked list data structure.
    public class LinkedList
    {
        // Reference to the first node in the linked list.
        public Node? Head { get; private set; }

        // Initializes an empty linked list.
        public LinkedList()
        {
            Head = null;
        }

        // Checks if a node containing specified data exists in the linked list.
        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Removes the first occurrence of a node with specified data from the linked list.
        public void Remove(int value)
        {
            if (Head == null) return;

            Node current = Head;

            if (current.Data == value) Head = Head.Next;

            while (current.Next != null)
            {
                Node previous = current;
                current = current.Next;
                if (current.Data == value)
                    previous.Next = current.Next;
            }
        }

        // Prints the elements of the linked list in order.
        public void PrintList()
        {
            if (Head == null)
            {
                Console.WriteLine("Head -> Null");
                return;
            }

            Node current = Head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

        // Adds a new node with the specified data to the end of the linked list.
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }
        }

        // Removes duplicates from the linked list.
        public void RemoveDuplicates()
        {
            if (Head == null) return;

            HashSet<int> uniqueKeys = new HashSet<int>();
            Node? traverser = Head;

            while (traverser != null)
            {
                if (uniqueKeys.Contains(traverser.Data))
                    Remove(traverser.Data);
                else
                    uniqueKeys.Add(traverser.Data);

                traverser = traverser.Next;
            }
        }

        // Merge sorted lists
        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            Node dummy = new Node(0);
            Node current = dummy;
            Node l1 = list1.Head;
            Node l2 = list2.Head;

            while (l1 != null && l2 != null)
            {
                if (l1.Data < l2.Data)
                {
                    current.Next = l1;
                    l1 = l1.Next;
                }else
                {
                    current.Next = l2;
                    l2 = l2.Next;
                }
                current = current.Next;
            }
            current.Next = l1 ?? l2;

            LinkedList mergedList = new LinkedList();
            mergedList.Head = dummy.Next;
            return mergedList;
        }

    }
}
