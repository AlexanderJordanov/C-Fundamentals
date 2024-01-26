using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = RepeatedString(randomString, number);
            Console.WriteLine(result);
        }

        static string RepeatedString(string input, int number)
        {
            string repeatedString = "";
            for (int i = 0; i < number; i++) 
            {
                repeatedString += input;
            }

            return repeatedString;
        }
    }
}
