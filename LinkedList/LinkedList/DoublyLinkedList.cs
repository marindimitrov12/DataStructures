using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        public Node head;

        public void InserthFront(int data)
        {
            Node newNode=new Node(data);
            newNode.next = head;
            newNode.prev = null;
            if (this.head!=null)
            {
                head.prev= newNode;
            }
            head = newNode;

        }
        public void InserthBack(int data)
        {
            Node newNode=new Node(data);
            if (head==null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            var last = GetLastNode();
            last.next = newNode;
            newNode.prev= last;
            }
        public Node GetLastNode()
        {
            var temp=head;
            while (temp != null)
                temp = temp.next;
            return temp;
        }
        public void InserthAfter(Node prevNode,int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            var newNode = new Node(data);
            var temp = prevNode.next;
            prevNode.next = newNode;
            newNode.next = temp;
            newNode.prev = prevNode;
            if (newNode.next!=null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void DeleteNodeByKey(int key)
        {
            if (head!=null&& head.Data==key)
            {
                head = head.next;
                head.prev = null;
                return;
            }
            var temp = head;
            while (temp!=null&&temp.Data!=key)
            {
                temp = temp.next;
            }
            if (temp==null) { return; }
            if (temp.next!=null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev!=null)
            {
                temp.prev.next = temp.next;
            }
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }
        public Node(int d)
        {
            this.Data = d;
            this.next = null;
            this.prev = null;
        }
    }
}
