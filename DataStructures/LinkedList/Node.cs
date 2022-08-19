using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class Node
    {
        public Node? next;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }   
    }

    public class LinkedList 
    {
        public Node? Head { get; set; }

        public void Append(int data)
        {
            if(Head == null)
            { 
                Head = new Node(data);
                return;
            }

            Node current = this.Head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = new Node(data);
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = Head;
            Head = newHead;
        }

        public void deleteWithValue(int data)
        {
            if (Head == null) return;

            if(Head.data == data)
            {
                Head = Head.next;
                return;
            }

            Node current = Head;
            while(current.next != null)
            {
                if(current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
    }
}
