namespace RotateLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine("Original List:");
            list.Display();

            list.RotateLeft(2);

            Console.WriteLine("List after rotating by 2:");
            list.Display();

        }
    }
}
