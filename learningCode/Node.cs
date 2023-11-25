using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCode
{
     public class Node <T>
    {
        public T Data { get; set; }                         // declares a public field named Data of type T.
                                                           // It represents the actual data stored in the node.
        public Node<T> Next { get; set; }                // declares a public field named Next of type Node<T>.
                                                        // It represents a reference to the next node in the linked list.
       //public Node<T> Previous { get; set; }
        public Node(T data)                  // constructor for the node class
        {
        
            Data = data;                     //assigns the provided data parameter to the Data field of the node
            
            Next = null;                  // this line initializes the Next field to null. Initially,
                                          // the node does not point to any other node,
                                          // so Next is set to null.

          //  Previous = null;
        }
    }
}
