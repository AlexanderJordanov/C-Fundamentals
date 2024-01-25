using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacter(input));
        }

        static string GetMiddleCharacter(string input) 
        {
            string character = "";

            if (input.Length % 2 == 1)
            {
                character = input[input.Length / 2].ToString();
            }

            else
            {
                character = input[input.Length / 2 - 1] + input[input.Length / 2].ToString();
            }
            return character;
        }

    }
}
