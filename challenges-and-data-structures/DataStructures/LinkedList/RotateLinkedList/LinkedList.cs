using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }

        // Add node to the list (helper method)
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        // Method to display the linked list
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " -> ");
                current = current.next;
            }
            Console.WriteLine("Null");
        }

        // Rotate the list left by k places
        public void RotateLeft(int k)
        {
            if (head == null || k == 0)
                return; // No need to rotate if list is empty or k is 0

            // Step 1: Calculate the length of the list
            Node current = head;
            int length = 1;
            while (current.next != null)
            {
                current = current.next;
                length++;
            }
            // Step 2: If k is greater than length, adjust k
            k = k % length;
            if (k == 0)
            {
                return; // No rotation needed if k == 0
            }
            // Step 3: Traverse the list again to the k-th node
            current.next = head; // Make the list circular temporarily
            current = head;
            for (int i = 1; i < k; i++)
                current = current.next;

            // Step 4: Adjust the pointers to rotate
            head = current.next;
            current.next = null; // Break the loop to form the new list
        }
    }
}
