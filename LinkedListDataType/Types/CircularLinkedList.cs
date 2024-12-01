using LinkedListDataType.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataType.Types
{
    public class CircularLinkedList<T> : ILinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Length { get; set; }

        public Node<T> Add(T value)
        {
            var node = new Node<T>();
            node.Value = value;

            if (Length == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            node.Next = Head;
            Length++;
            return node;
        }

        public Node<T> AddFirst(T value)
        {
            var node = new Node<T>();
            node.Value = value;
            node.Next = Head;

            Head = node;
            if (Length == 0)
            {
                Tail = node;
                node.Next = Head;
            }
            else
            {
                Tail.Next = Head;
            }

            Length++;



            return Head;
        }

        public Node<T> AddLast(T value)
        {
            var node = new Node<T>();
            node.Value = value;

            if (Length == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            node.Next = Head;

            Length++;

            return Head;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Node<T> Delete(T value)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Display_Recursively(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public bool HasLoop(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public Node<T> Insert(int index, T value)
        {
            var node = new Node<T>(value);
            var head = Head;
            if (head == null || index == 0)
            {
                return AddFirst(value);
            }

            if (index  >= Length)
            {
                return AddLast(value);
            }

            var i = 0;
            Node<T> previous = null;
            while (head != null)
            {
                previous = head;
                head = head.Next;
                i++;

                if (i == index)
                {
                    break;
                }
            }

            if (head == Tail)
            {
                return AddLast(value);
            }
            else
            {
                previous.Next = node;
                node.Next = head;
            }

            Length++;
            return Head;
        }

        public Node<T> Intersection(Node<T> node1, Node<T> node2)
        {
            throw new NotImplementedException();
        }

        public T Max()
        {
            throw new NotImplementedException();
        }

        public Node<T> Merge(Node<T> first, Node<T> second)
        {
            throw new NotImplementedException();
        }

        public Node<T> Middle(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public T Min()
        {
            throw new NotImplementedException();
        }

        public void PrintReverse(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public Node<T> Reverse()
        {
            throw new NotImplementedException();
        }

        public void Reverse_Recursively(Node<T> first, Node<T> second)
        {
            throw new NotImplementedException();
        }

        public Node<T> Search(T value)
        {
            throw new NotImplementedException();
        }

        public int Sum()
        {
            throw new NotImplementedException();
        }
    }
}
