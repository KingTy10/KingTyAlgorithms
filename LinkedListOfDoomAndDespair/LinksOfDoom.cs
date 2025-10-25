using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace LinkedListOfDoomAndDespair
{
    public class LinksOfDoom
    {
        public class LinkList<T>
        {
            private Node<T>? Head { get; set; }
            private Node<T>? Tail { get; set; }
            public int Count { get; private set; }

            private class Node<T>
            {
                public T Value { get; set; }
                public Node<T>? Next { get; set; }
            }

            // Add to the end of the list
            public void Append(T data)
            {
                var newNode = new Node<T> { Value = data, Next = null };

                if (Head == null)
                {
                    Head = Tail = newNode;
                }
                else
                {
                    Tail!.Next = newNode;
                    Tail = newNode;
                }

                Count++;
            }

            // Add to the front of the list
            public void Prepend(T data)
            {
                var newNode = new Node<T> { Value = data, Next = Head };
                Head = newNode;

                if (Tail == null)
                    Tail = Head;

                Count++;
            }

            // Get an element by position (0-indexed)
            public T GetAt(int pos)
            {
                Node<T> temp = Head;
                int i = 0;

                while (i < pos && temp != null)
                {
                    temp = temp.Next;
                    i++;
                }

                return temp != null ? temp.Value : default!;
            }

            // Remove first element and return it (used by Stack/Queue)
            public T RemoveFirst()
            {
                if (Head == null) throw new InvalidOperationException("List is empty.");

                T value = Head.Value;
                Head = Head.Next;
                if (Head == null) Tail = null;
                Count--;
                return value;
            }

            public bool IsEmpty() => Count == 0;

            // For debugging
            public void PrintAll()
            {
                Node<T> temp = Head;
                while (temp != null)
                {
                    Console.Write(temp.Value + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine("null");
            }
        }
    }
}

