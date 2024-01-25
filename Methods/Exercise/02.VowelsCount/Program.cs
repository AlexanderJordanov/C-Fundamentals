using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bullshit = Console.ReadLine();

            int vowels = GetVolews(bullshit);
            Console.WriteLine(vowels);
        }


        static int GetVolews (string bullshit)
        {
            int count = 0;

            bullshit = bullshit.ToLower();

            foreach (char symbol in bullshit)
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'u' || symbol == 'i')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
