using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeImplementation
{
    public class Menu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("         Select any option below to perform Deque activities         ");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("1 : ADD item to FRONT of the deque");
            Console.WriteLine("2 : ADD item to BACK of the deque");
            Console.WriteLine("3 : REMOVE item from FRONT of the deque");
            Console.WriteLine("4 : REMOVE item from BACK of the deque");
            Console.WriteLine("5 : CLEAR all items from the deque");
            Console.WriteLine("exit : To exit the program!");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine($"*Note : Its an integer Deque which accepts value between 0 to {Int32.MaxValue.ToString()}");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Please enter the option number (example: 1 for adding new item to the front of the deque)");
        }
    }
}
