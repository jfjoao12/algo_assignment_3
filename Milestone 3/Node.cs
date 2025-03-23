using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Node<T>
    {
        public T Element { get; set; }

        public Node<T> Head { get; set; }
        public Node<T> Next { get; set; }


        public Node(T element = default, Node<T> previous = null, Node<T> next = null)
        {

            Element = element;
            Next = next;
        }
    }

}
