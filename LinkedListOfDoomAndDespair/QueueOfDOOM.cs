using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedListOfDoomAndDespair.LinksOfDoom;

namespace LinkedListOfDoomAndDespair
{
    public class QueueOfDOOM<T> : LinksOfDoom.LinkList<T>
    {
        private Node<T> data;
       private Node<T> Head;
        public void Push(T data) 
        {
            Node<T> temp = this.Head;
            Node<T> newNode = new Node<T>
            {
                Value = data,
                Next = null


            };
            while (temp?.Next != null) 
            {
                temp= temp.Next;
            
            
            }
            if (temp != null)
            { 
                temp.Next = newNode;
            
            } 

        }
        //This si a pop but for the queue this is name dequeue
        public void Dequeue() 
        {

            if (this.Head !=null) 
            {
                this.Head= this.Head.Next;
            
            }
        }
        public T Peek() 
        {
            if (data == null) 
            {
                return default(T);
            
            }
            return Head.Value;
        }
        public bool IsEmpty()
        {
            return this.Head == null;   
        }

    }
}
