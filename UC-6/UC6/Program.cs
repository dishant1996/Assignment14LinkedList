using System;
using System.Collections.Generic;

namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program");

            LinkedList linkdedList = new LinkedList();
            linkdedList.Add(56);
            linkdedList.Add(30);
            linkdedList.Add(70);
            linkdedList.Display();
            linkdedList.DeleteLastNode();
            linkdedList.Display();
        }
    }
}