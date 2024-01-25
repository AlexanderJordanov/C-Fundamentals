using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int minNumber = GetLowestNumber(firstNumber, secondNumber);
            minNumber = GetLowestNumber(minNumber, thirdNumber);
            Console.WriteLine(minNumber);
        }

        static int GetLowestNumber (int a, int b)
        {
            if (a < b) 
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
