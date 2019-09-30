using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Header { get; set; }
        public void Add(int val)
        {
            Node current = Header;
            Node node = new Node(val);

            // basic condition 
            if (current == null)
            {

                Header = node;
                return;
            }

            // reach the end
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
            node.Previous = current;
            return;
        }

        public void Delete(int val)
        {
            Node current = Header;
            
            // reach the end
            while (current != null && current.Value != val)
            {                
                current = current.Next;
            }

            if (current != null && current.Value == val)
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
            }

        }

        public List<int> ToList()
        {
            Node current = Header;
            List<int> list = new List<int>();
            // reach the end
            while (current != null )
            {
                list.Add(current.Value);

                // move to the next
                current = current.Next;
            }

            // result
            return list;
        }


        public void Revere()
        {
            Node current = Header;
          
            while (current != null)
            {
                // swap
                Node tempNextCurrent  = current.Next;
                current.Next = current.Previous;
                current.Previous= tempNextCurrent;

                // move to the next
                current = current.Next;
            }

         
        }

    }

}

public class Node
{
    public Node(int val)
    {
        this.Value = val;
    }
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }
}
