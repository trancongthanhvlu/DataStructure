using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class ListByLinkedList
    {
        Node front,end;

        public ListByLinkedList()
        {
            this.front = null;
            this.end = null;
        }
        //          Append Element
        public void Append(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {                
                front = newnode;
                this.end = newnode;
            }
            else
            {
                this.end.next = newnode;
                this.end = newnode;
            }
        }
        //          Insert Element at index
        public bool Insert (int index, int data)
        {
            // 
            bool result = false;
            // new node store data
            Node newnode = new Node(data);            
            Node temp = front;
            while (temp !=null && index > 0)
            {
                index--;
                temp = temp.next;
            }
            if (index == 0)
            {
                newnode.next = temp.next;
                temp.next = newnode;
                result = true;
            }
            return result;
        }
        //          Remove Element
        public bool Remove (int data)
        {
            bool result = false;
            Node temp = this.front;
            if (front != null)
            {
                if (front.data == data)
                {
                    front = front.next;
                    result = true;
                }
                else
                {
                    while (temp.next != null && temp.next.data != data)
                    {

                    }
                }
            }
            return result;
        }
        //          Find Element
        //          Swap Elements
        //          Traversing the List
        public void PrintList()
        {
            Node temp = this.front;
            Console.Write(" List ");
            while (temp != null)
            {
                Console.Write(" " + temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        //          Clear List
        public void ClearList()
        {
            front = null;
            end = null;
        }
        
    }
}
