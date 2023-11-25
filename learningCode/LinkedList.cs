using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
     class  LinkedList<T>
    {
        private Node<T> head;       //declares a private field named head of type Node<T>.
                                    //It represents the starting point of the linked list.
        
        //constructor;
        //it initializes the head to null, indicating an empty list.
        public LinkedList() {

            head = null;
        }
        public void AddFirst(T data) 
        {
            Node<T> newNode = new Node<T>(data); 

            newNode.Next = head;  //sets the new node to the current head
            head = newNode; // updates the head 
        }
        public void AddLast(T data) 
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null) // sets the head to newnode and returns if the list is empty
            {
                head = newNode; 
                return;
            }
            Node<T> current = head;
            while (current.Next != null) //if list is note empty,
                                         //it iterates through the list to find the last node
            {
                current = current.Next; // appends the new node to the Next of the last node
            }
            current.Next = newNode;
        }

        public void Display() {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data+ " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        //public bool Search(T x)
        //{
        //    Node<T> current = head;
        //    if (current == null) //If the list is empty, it returns.
        //    {
        //        return false;
        //    }
        //    while (current != null)
        //    {
        //        if (current.Data == x)
        //            return true; // data found
        //        current = current.Next;

        //    }
        //    return false;
        //}

        public void Remove (T data) {
        
            if(head == null) //If the list is empty, it returns.
            {
                return;
            }
            if (head.Data.Equals(data)) //If the node to be removed is the head,
                                        //it updates the head to the next node.
            {
                head = head.Next;
                return;
            }

            Node<T> current = head;
            //It iterates through the list to find the node before the one to be removed (current).
            while (current.Next != null && !current.Next.Data.Equals(data))
            {
                //If the node to be removed is found (current.Next),
                //it updates the Next of current to skip the node to be removed.

                current = current.Next;
            }
            if (current.Next != null)
            { 
              current = current.Next.Next; 
            }
        }


    }
}
