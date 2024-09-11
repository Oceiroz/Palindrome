using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput("Write sumn to see if its a palindrome");
        }
        static void GetInput(string inputMessage)
        {
            Console.WriteLine($"{inputMessage}");
            var rawInput = Console.ReadLine();
            char[] inputList = rawInput.ToCharArray();
            Array.Reverse(inputList);
            string inputReverse = new string(inputList);
            if (inputReverse == rawInput)
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }
        }
    }
}
