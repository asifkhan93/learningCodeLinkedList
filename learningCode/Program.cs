using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            CircularLinkedList<int> circularLinkedList = new CircularLinkedList<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(76);

            singlyLinkedList.AddLast(20);
            singlyLinkedList.AddLast(40);
            singlyLinkedList.AddLast(50);

            doublyLinkedList.AddLast(90);
            doublyLinkedList.AddLast(80);
            doublyLinkedList.AddLast(70);
            doublyLinkedList.AddFirst(52);

            circularLinkedList.AddLast(1);
            circularLinkedList.AddLast(2);
            circularLinkedList.AddLast(3);

            Console.WriteLine("CircularLinked List: ");
            circularLinkedList.Display();

            Console.WriteLine("DoublyLinked List: ");
            doublyLinkedList.Display();

            Console.WriteLine("SinglyLinked List: ");
            singlyLinkedList.Display();

            Console.WriteLine("Linked List: ");
            linkedList.Display();

            linkedList.AddFirst(40);
            Console.WriteLine("\n After adding 40 Linked List: ");
            linkedList.Display();

            linkedList.AddLast(90);
            Console.WriteLine("\n After adding 90 Linked List: ");
            linkedList.Display();

            linkedList.Remove(56);

            Console.WriteLine("\n After removing Linked List: ");
            linkedList.Display();


        }
    }
}
