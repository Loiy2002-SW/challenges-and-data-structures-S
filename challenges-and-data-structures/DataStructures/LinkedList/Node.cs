

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    public class Node
    {
        public int Data {  get; set; }
        public Node? Next { get; set; }


        public Node(int data = 0)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
