

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
   
       
        /// Represents a node in a singly linked list.
        public class Node
        {
            /// Gets or sets the data stored in the node.
            public int Data { get; set; }

            /// Gets or sets the reference to the next node in the linked list.
            public Node? Next { get; set; }

            /// Initializes a new instance of the Node class with optional data.
            public Node(int data = 0)
            {
                this.Data = data;
                this.Next = null;
            }
        }

}
