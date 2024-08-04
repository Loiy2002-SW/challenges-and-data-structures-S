

using challenges_and_data_structures.Data_Structures.LinkedList;
using challenges_and_data_structures.DataStructures.Stack_Queue.ReverseStackUsingQueue;

namespace challenges_and_data_structures
{
    public class MergeSorted
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(5);
            list1.Add(10);
            list2.Add(4);
            list2.Add(8);
            list2.Add(9);
            list2.Add(12);
            list2.Add(20);

            Console.WriteLine($"List1: ");
            list1.PrintList();

            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            Console.WriteLine($"List2: ");
            list2.PrintList();

            Console.WriteLine($"\nList after merging:");
            LinkedList.MergeSortedLists(list1, list2).PrintList();


            Console.ReadKey();


        }



    }

}
