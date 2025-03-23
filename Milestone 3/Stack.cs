using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Stack<T>
    {
        public Node<T> Head { get; set; }

        public int Size { get; set; }

        public Stack()
        {
            Head = null;
            Size = 0;
        }

        public void Push(T element)
        {
            Node<T> newNode = new Node<T>(element);

            newNode.Next = Head;
            Head = newNode;
            Size++;
        }

        public T Top()
        {
            if (IsEmpty())
            {
                throw new ApplicationException();
            }
            return Head.Element;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new ApplicationException();
            }

            T returnElement = Head.Element;
            Head = Head.Next;
            Size--;
            return returnElement;
        }

        public void Clear()
        {
            Head = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}
