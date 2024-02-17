using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linked_Lists
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int value,Node n)
        {
            data = value;
            next = n;
        }
    }
    public class SingleLinkedList
    {
        Node head, tail;
        int size;
        public SingleLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool isEmpty() {  return size == 0; }

        public void AddLast(int  value) { 
            Node newNode= new Node(value, null);
            if(isEmpty())
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            tail= newNode;
            size++;
        }

        public void AddFirst(int value)
        {
            Node newNode= new Node(value, null);
            if(isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        public void AddAnywhere(int value,int position)
        {
            Node currentNode = head;
            Node newNode= new Node(value, null);
            int i = 0;
            while(i<position-1)
            {
                currentNode=currentNode.next;
                i++;
            }
            newNode.next=currentNode.next;
            currentNode.next=newNode;
        }
       
        //deleting list

        public void DeleteFirst()
        {
            if (isEmpty()) { Console.WriteLine("Cannot perofrm this task"); }
            else { head=head.next; size--; }
            
        }

        public void RemoveAnywhere(int pos)
        {
            Node currentNode = head;
            int i = 1;
            while(i<pos-1)
            {
                currentNode = currentNode.next;
                i++;
            }
            currentNode.next=currentNode.next.next;
        }

       
        public void Display()
        {
            Node currentNode= head;
            while(currentNode != null)
            {
                Console.Write(currentNode.data+"->");
                currentNode = currentNode.next;
            }
        }
    }
}
