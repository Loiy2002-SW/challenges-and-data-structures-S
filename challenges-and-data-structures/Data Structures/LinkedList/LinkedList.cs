

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    public class LinkedList
    {
        public Node? Head {  get; private set; }

        public LinkedList()
        {
            Head = null;
        }

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
    

        public void Remove(int value)
        {
            if (Head == null) return;

            Node current = Head;

            if (current.Data == value) Head = Head.Next;

            while (current.Next != null)
            {
                Node previous = current;
                current = current.Next;
                if (current.Data == value) previous.Next = current.Next ;
            }
         
        }


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
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

    }
}
