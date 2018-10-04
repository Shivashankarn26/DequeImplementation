using System;
using System.Text.RegularExpressions;

namespace DequeImplementation
{
    public static class Support
    {
        public static bool IntegerCheck(string input)
        {
            Regex regex = new Regex("^\\d+$");

            if (!regex.IsMatch(input))
            {
                Console.WriteLine($"Input '{input}' is not a valid integer. Please insert only interger between 0 to {Int32.MaxValue.ToString()}.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
