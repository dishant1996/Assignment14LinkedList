using System;
using System.Collections.Generic;

namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList linkedList = new LinkedList();


            Console.WriteLine("Adding  elements into Linkedlist using AddLast Method:");
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Append(25);
            linkedList.Display();

            Console.ReadLine();

        }
    }
}