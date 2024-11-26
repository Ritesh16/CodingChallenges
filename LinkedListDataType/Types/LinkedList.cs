﻿using LinkedListDataType.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataType.Types
{
    public class LinkedList<T> : ILinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Length { get; set; }

        public LinkedList()
        {
            Length = 0;
        }

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

            Length++;
            return node;
        }

        public int Count()
        {
            return Length;
        }

        public void Display()
        {
            var head = Head;
            while (head != null)
            {
                Console.WriteLine(head.Value.ToString());
                head = head.Next;
            }
        }

        public void Display_Recursively(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value.ToString());
                Display_Recursively(node.Next);
            }
        }

        public int Sum()
        {
            var sum = 0;
            var head = Head;

            while (head != null)
            {
                sum += Convert.ToInt32(head.Value);
                head = head.Next;
            }

            return sum;
        }

        public void Reverse(Node<T> node)
        {
            if (node != null)
            {
                Reverse(node.Next);
                Console.WriteLine(node.Value.ToString());
            }
        }

        public T Max()
        {
            T max = default(T);
            var head = Head;
            while (head != null)
            {
                if (head.Value.CompareTo(max) > 0)
                {
                    max = head.Value;
                }

                head = head.Next;
            }

            return max;
        }

        public T Min()
        {
            T min = Head.Value;
            var head = Head;
            while (head != null)
            {
                if (head.Value.CompareTo(min) < 0)
                {
                    min = head.Value;
                }

                head = head.Next;
            }

            return min;
        }

        public Node<T> AddFirst(T value)
        {
            var node = new Node<T>();
            node.Value = value;
            node.Next = Head;

            Head = node;

            Length++;

            return Head;
        }

        public Node<T> AddLast(T value)
        {
            var node = new Node<T>();
            node.Value = value;

            Tail.Next = node;
            Tail = node;

            Length++;

            return Head;
        }

        public Node<T> Search(T value)
        {
            var head = Head;
            Node<T> node = null;
            while (head != null)
            {
                if(head.Value.Equals(value))
                {
                    node = head;
                    break;
                }

                head = head.Next;
            }

            return node;
        }

        public Node<T> Insert(int index, T value)
        {
            var node = new Node<T>(value);
            var head = Head;
            if(head == null || index == 0)
            {
                return AddFirst(value);
            }

            if(index - 1 == Length)
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

            previous.Next = node;
            node.Next = head;

            Length++;
            return Head;
        }
    }
}