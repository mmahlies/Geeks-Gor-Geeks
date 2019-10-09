using System;
using System.Collections;
using System.Collections.Generic;

namespace Towers_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // define stacks
            StackWithName  source = new StackWithName ("sourse");
            StackWithName  auxliry = new StackWithName ("auxliry");
            StackWithName  destination = new StackWithName ("destination");

            // add data
            //source.Push(3);
            source.Push(2);
            source.Push(1);

            TowersMovement(source.Count, source, auxliry, destination);
            Console.Read();
        }


        static void TowersMovement(int n, StackWithName source, StackWithName auxliry, StackWithName destination)
        {
            if (n == 0)
            {
               // Console.WriteLine("{0} => {1}", source.Name,destination.Name);
                return;
            }

            TowersMovement(n - 1, source, destination, auxliry);
            Console.WriteLine("{0} => {1}", source.Name, destination.Name);
            TowersMovement(n - 1, auxliry, source, destination);

        }
    }

    public class StackWithName : Stack<int>
    {
        public string Name { get; set; }
        public StackWithName(string name)
        {
            this.Name = name;
        }
    }
}
