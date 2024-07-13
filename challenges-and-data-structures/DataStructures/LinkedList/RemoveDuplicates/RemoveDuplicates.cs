

using challenges_and_data_structures.Data_Structures.LinkedList;

namespace challenges_and_data_structures
{
    public class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(6);

            Console.WriteLine($"List: ");
            list.PrintList();

            list.RemoveDuplicates();

            Console.WriteLine($"\nList after removing duplicates:");
            list.PrintList();



            Console.ReadKey();


        }



    }

}
