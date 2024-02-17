using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Binary_Tree
{
    public class Node
    {
        public int data;
        public Node left; public Node right;

        public Node(int val,Node l,Node r)
        {
            data = val;
            left = l;
            right = r;
        }
    }
    public class Insertion_BinarySearchTree
    {
      public  Node root;
        public Insertion_BinarySearchTree()
        {
            root = null;
        }

        public void Insert(Node Troot,int val)
        {
            Node currentNode = null;
            while(Troot != null)
            {
                currentNode = Troot;
                if (val == Troot.data)
                    return;
                else if(val< Troot.data)
                    Troot = Troot.left;
                else if(val> Troot.data)
                    Troot = Troot.right;
            }
            Node newNode=new Node(val,null,null);
            if(root != null)
            {
                if(val<currentNode.data)
                    currentNode.left = newNode;
                else
                    currentNode.right = newNode;
            }
            else
            {
                root= newNode;
            }
        }

        public Node InsertRecursive(Node troot,int ele)
        {
            if(troot != null)
            {
                if(ele<troot.data)
                    troot.left=InsertRecursive(troot.left,ele);
                else if(ele>troot.data)
                    troot.right=InsertRecursive(troot.right,ele);
            }
            else
            {
                Node newnode=new Node(ele,null,null);
                troot = newnode;
            }
            return troot;
        }

        public void InorderTravell(Node root)
        {
            if(root!=null)
            {
                InorderTravell(root.left);
                Console.Write(root.data+" ");
                InorderTravell(root.right);
            }
        }

        public void PreorderTravell(Node root)
        {
            if (root!=null)
            {
                Console.Write(root.data+" ");
                PreorderTravell(root.left);
                PreorderTravell(root.right);
            }
        }

        public void PostorderTravell(Node root)
        {
            if (root != null)
            {

                PostorderTravell(root.left);
                PostorderTravell(root.right);
                Console.Write(root.data + " ");
            }
        }

        public bool SearchElement(int ele)
        {
            Node currentNode = root;
            while (currentNode!=null)
            {
                if(ele==currentNode.data)
                {
                    return true;
                }
                else if(ele<currentNode.data)
                {
                    currentNode=currentNode.left;
                }
                else
                {
                    currentNode=currentNode.right;
                }
            }
            return false;
        }

        public bool RecursiveSearch(Node root,int ele)
        {
            if(root!=null)
            {
                if (ele == root.data)
                    return true;
                else if(ele<root.data)
                    return RecursiveSearch(root.left,ele);
                else
                    return RecursiveSearch(root.right,ele);
            }
            return false;
        }

        public int CountNodes(Node root)
        {
            int x=0, y=0;
            if (root!=null)
            {
                x = CountNodes(root.left);
                y = CountNodes(root.right);
                return x + y + 1;
            }
            return 0;
        }

        public int HeightOfNodes(Node root)
        {
            int x = 0, y = 0;
            if (root != null)
            {
                x = HeightOfNodes(root.left);
                y = HeightOfNodes(root.right);
                if(x>y)
                    return x+1;
                else
                    return y+1;
            }
            return 0;
        }

    }
}
