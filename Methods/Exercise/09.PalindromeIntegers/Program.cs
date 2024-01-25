using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(isPalindrome(input));
            }
        }

        static bool isPalindrome (string input)
        {

            string reverseInput = "";
            bool isPalindrome = false;

            for (int i = input.Length - 1; i >= 0; i--) 
            {
                reverseInput += input[i];
            }
            if (input == reverseInput)
            {
                isPalindrome = true;
            }
            else 
            { 
                isPalindrome = false;
            }

            return isPalindrome;
        }

    }
}
