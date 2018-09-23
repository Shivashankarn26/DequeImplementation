using System;

namespace DequeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.PrintMenu();
            string input = Console.ReadLine();

            IDeque deque = new Deque();

            while (input != "exit")
            {
                try
                {
                    Console.Clear();
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Enter Item to be added to front of the Queue : ");
                            input = Console.ReadLine();
                            if (Support.IntegerCheck(input))
                            {
                                deque.AddToFront(input);
                            }
                            break;
                        case "2":
                            Console.WriteLine("Enter Item to be added to BACK of the Queue : ");
                            input = Console.ReadLine();
                            if (Support.IntegerCheck(input))
                            {
                                deque.AddToBack(input);
                            }
                            break;
                        case "3":
                            deque.RemoveFromFront();
                            break;
                        case "4":
                            deque.RemoveFromBack();
                            break;
                        case "5":
                            deque.Clear();
                            break;
                        default:
                            Console.WriteLine("Enter Valid Option");
                            break;
                    }
                }
                catch (Exception e) { }
                Menu.PrintMenu();
                input = Console.ReadLine();
            };            
        }
    }
}
