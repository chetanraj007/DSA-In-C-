using DataStructures.Binary_Tree;
using DataStructures.Heaps;
using DataStructures.Linked_Lists;
using DataStructures.Linked_Lists.Double_linked;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Heap hp=new Heap();
            hp.insert(10);
            hp.insert(20);
            hp.insert(130);
            hp.insert(25);
            hp.disaplyHeap();
            Console.ReadLine();
        }

        static void SingleList()
        {
            SingleLinkedList sl = new SingleLinkedList();
            sl.AddLast(10);
            sl.AddLast(20);
            sl.AddLast(30);
            sl.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Ädding to the begging of the list");
            sl.AddFirst(9);
            sl.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Ädding to the Anywhere in the list");
            sl.AddAnywhere(25, 3);
            sl.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Deleting to the begging of the list");
            sl.DeleteFirst();
            sl.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Deleting to the anywhere of the list");
            sl.RemoveAnywhere(4);
            sl.Display();
            Console.ReadLine();
        }

        static void DoubleList()
        {
            DoubleLinkedList dL = new DoubleLinkedList();
            Console.WriteLine("\nAfter adding to last");
            dL.AddLastToDoubleList(2);
            dL.AddLastToDoubleList(20);
            dL.AddLastToDoubleList(200);
            dL.AddLastToDoubleList(400);
            dL.AddLastToDoubleList(500);
            dL.Display();
            Console.WriteLine("\n");
            Console.WriteLine("\nAfter adding to first");
            dL.AddFirst(1);
            dL.Display();
            Console.WriteLine("\n");
            Console.WriteLine("\nAfter adding to any position");
            dL.AddAny(45, 3);
            dL.Display();
            Console.WriteLine("\n");
            Console.WriteLine("\nAfter removing from begining");
            dL.RemoveFisrt();
            dL.Display();
            Console.WriteLine("\n");
            Console.WriteLine("\nAfter removing from last");
            dL.RemoveLast();
            dL.Display();
            Console.WriteLine("\n");
            Console.WriteLine("\nAfter removing from any position");
            dL.RemoveAny(4);
            dL.Display();
            Console.ReadLine();
        }

        static void BinaryTree()
        {
            Insertion_BinarySearchTree bt = new Insertion_BinarySearchTree();
            bt.Insert(bt.root, 50);
            bt.Insert(bt.root, 30);
            bt.Insert(bt.root, 80);
            bt.Insert(bt.root, 10);
            bt.Insert(bt.root, 40);
            bt.Insert(bt.root, 60);
            bt.Insert(bt.root, 90);
            Console.WriteLine("Inorder travesal");
            bt.InorderTravell(bt.root);
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("PreOrder travesal");
            bt.PreorderTravell(bt.root);
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("PostOrder travesal");
            bt.PostorderTravell(bt.root);
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("Searcheing the Element 30");
            Console.WriteLine(bt.SearchElement(30));
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("Number of nodes");
            Console.WriteLine(bt.CountNodes(bt.root));
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("Height of nodes");
            Console.WriteLine(bt.HeightOfNodes(bt.root));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
