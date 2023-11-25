using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
    public class CircularLinkedList<T>
    {
        public CircularNode<T> Head {  get; set; }

        public void AddLast(T data)
        {
            CircularNode<T> newNode = new CircularNode<T>(data);

            if(Head == null) 
            {
                Head = newNode;
                return;

            }
            CircularNode <T> current = Head;
            while(current.Next != Head)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = Head;
        }
        public void Display() 
        {
            CircularNode<T> current = Head;
            do
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            } while (current != Head);
            Console.WriteLine();
        }

    }
}
