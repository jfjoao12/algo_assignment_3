using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_3;

namespace Assignment_3
{
    using System;

    public class Queue<T>
    {

        private Node<T> head;  
        private Node<T> tail;  
        private int size;      
        public int Size { get { return size; } }
        public Node<T> Head { get { return head; } }

        public Node<T> Tail { get { return tail; } }


        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void Enqueue(T element)
        {
            Node<T> newNode = new Node<T>(element);

            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            size++;
        }

        public T Front()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue is empty. Cannot retrieve the front element.");
            }

            return head.Element;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("Queue is empty. Cannot dequeue.");
            }

            T frontItem = head.Element;
            head = head.Next;  
            size--;

            if (IsEmpty())
            {
                tail = null;
            }

            return frontItem;
        }

        public bool IsEmpty()
        { 
            return size == 0; 
        }

        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
        }
    }



}
