using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
    public class SinglyLinkedList <T>
    {
        public Node<T> Head { get; set; }   // Reference to the head (first node) of the list.

        // Method to add a new node with data at the end of the list.
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);   // Create a new node.

            // If the list is empty, set the new node as the head.
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node<T> current = Head;

            // Traverse the list to find the last node.
            while (current.Next != null)
            {
                current = current.Next;
            }

            // Attach the new node to the last node.
            current.Next = newNode;
        }

        // Method to display the elements of the list.
        public void Display()
        {
            Node<T> current = Head;   // Start from the head.

            // Traverse the list and print the data of each node.
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;   // Move to the next node.
            }

            Console.WriteLine();   // Print a newline after displaying all elements.
        }
    }
}
