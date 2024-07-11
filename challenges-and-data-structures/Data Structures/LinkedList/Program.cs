

using challenges_and_data_structures.Data_Structures.LinkedList;

namespace challenges_and_data_structures
{
    public class Program
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

            list.PrintList();

            Console.WriteLine($"List includes 5: {list.Includes(5)}");

            list.Remove(5);


            list.PrintList();

            Console.WriteLine($"List includes 5: {list.Includes(5)}");

            Console.ReadKey();


        }



    }

}
