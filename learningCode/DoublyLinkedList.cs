using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
    public class DoublyLinkedList <T>
    {
        public DoublyNode<T> Head { get; set; }
        public DoublyNode<T> Tail { get; set; }

        public void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T> { Data = data };
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;

            }
        }


        public void AddLast(T data)
        {

            DoublyNode<T> newNode = new DoublyNode<T> { Data = data};

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else { 
            
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }


        }
        public void Display()
        {
            //Node<T> current = Head;   // Start from the head.

            // Traverse the list and print the data of each node.
            while (Head != null)
            {
                Console.Write(Head.Data + " ");
                Head = Head.Next;   // Move to the next node.
            }

            Console.WriteLine();   // Print a newline after displaying all elements.
        }

    }
}
