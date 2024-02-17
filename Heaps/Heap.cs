using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heaps
{
    public class Heap
    {
        int[] data;
        int csize;
        int maxsize;

        public Heap()
        {
            maxsize = 10;
            data = new int[maxsize];
            csize = 0;
          

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int length() { return csize; }

        public bool isEmpty() {  return csize == 0; }

        public void insert(int ele)
        {
            if(csize==maxsize) { return; }
            csize = csize + 1;
            int HeapIndex = csize;
            while(HeapIndex>1 && ele > data[HeapIndex/2]) 
            {
                data[HeapIndex] = data[HeapIndex/2];
                HeapIndex = HeapIndex / 2;
            }
            data[HeapIndex] = ele;
        }

        public void disaplyHeap()
        {
            for (int i = 0;i < data.Length;i++)
            {
                Console.Write(data[i]+" ");
            }
        }
    }
}
