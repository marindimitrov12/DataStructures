using static LinkedList.LinkedList;

namespace LinkedList
{
    public class LinkedList
    {
      
           public class Node
        {
            public Node next=null;
            public int data; 
        }
        private Node head = null;

        public Node First { get => this.head; }
        public Node Last
        {
            get
            {
                Node curr = head;
                if (curr == null)
                {
                    return null;
                }
                while (curr != null)
                    curr = curr.next;
                return curr;
            }
        }
        public void Append(int data)
        {
            Node newNode=new Node();
            newNode.data = data;
            if (head == null)
                head = newNode;
            else
                Last.next= newNode;
        }
        public void Delete(Node n)
        {
            if (head==n)
            {
                head = n.next;
                n.next = null;
            }
            else
            {
                Node curr = head;
                while (curr != null)
                {
                    if (curr.next==n)
                    {
                        curr.next = n.next;
                        n.next = null;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }




    }
}