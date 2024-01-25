using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol > secondSymbol)
            {
                char swap = firstSymbol;
                firstSymbol = secondSymbol;
                secondSymbol = swap;
            }

            PrintInBetween (firstSymbol, secondSymbol);
        }

        static void PrintInBetween (char firstSymbol, char secondSymbol)
        {
            for (int i = firstSymbol + 1; i < secondSymbol; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
