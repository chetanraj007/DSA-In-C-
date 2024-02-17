using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linked_Lists.Double_linked
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int val, Node nxt, Node prv)
        {
            data = val;
            next = nxt;
            prev = prv;
        }
    }
    public class DoubleLinkedList
    {
        public Node head,tail;
        int size=0;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool isEmpty() { return size == 0; }

        public void AddLastToDoubleList(int e)
        {
            Node newNode=new Node(e,null,null);
            if (isEmpty())
            {
                head=newNode;
                tail=newNode;
            }
            else
            {
                tail.next=newNode;
                newNode.prev=tail;
                tail = newNode;
            }
            size++;
        }

        public void AddFirst(int e)
        {
            Node newNode=new Node(e,null,null);
            if (isEmpty())
            {
                head=newNode;
                tail=newNode;
            }
            else
            {
                newNode.next = head;
                head.prev=newNode;
                head = newNode;
            }
            size++;
        }

        public void AddAny(int e,int pos)
        {
            Node newNode = new Node(e,null,null);
            Node currentNode = head;
            int i = 1;
            while (i < pos-1)
            {
                currentNode=currentNode.next;
                i++;
            }
            newNode.next=currentNode.next;
            currentNode.next.prev=newNode;
            currentNode.next=newNode;
            newNode.prev = currentNode;
            size++;
        }

        public void RemoveFisrt()
        {
            if (isEmpty()) { return; }
            head=head.next;
            head.prev = null;
            size--;
            if(isEmpty())
            {
                tail = null;
            }
            else { head.prev = null; }
        }

        public void RemoveLast()
        {
            if (isEmpty()) { return; }
            tail = tail.prev;
            tail.next=null;
            size--;
        }

        public void RemoveAny(int pos)
        {
            int i = 1;
            Node currentNode = head;
            while(i<pos-1)
            {
                currentNode = currentNode.next;
                i++;
            }
            currentNode.next = currentNode.next.next;
            currentNode.next.prev=currentNode;
            size--;
        }
        public void Display()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data+"=>");
                currentNode =currentNode.next;

            }
        }
    }
}
