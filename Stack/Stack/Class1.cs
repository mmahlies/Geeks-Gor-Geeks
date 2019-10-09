using System;

namespace Stack
{
    public class Stack
    {
        public LinkedList.LinkedList linkedList { get; set; }
        public Stack()
        {

        }

        public void Push(int val)
        {
            linkedList.AddFront(val);
        }


        public int Peek()
        {
            return linkedList.Header.Value;
        }


    }
}
