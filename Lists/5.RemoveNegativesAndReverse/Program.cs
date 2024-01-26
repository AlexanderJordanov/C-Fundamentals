using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] < 0)
                {
                    number.RemoveAt(i);
                    i--;
                }
            }

            number.Reverse();

            if (number.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", number));
            }
        }
    }
}
