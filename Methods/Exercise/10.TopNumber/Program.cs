using System;
using System.Diagnostics.CodeAnalysis;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
    
            for (int i = 1; i <= end; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


        static bool IsTopNumber(int i)
        {

            if (IsDivisible(i) && OneOddDigit(i))
            {

                return true;

            }

            return false;

        }


        static bool IsDivisible (int i)
        {

            int sumOfDigits = 0;

            while (i > 0)
            {
                int digit = i % 10;
                sumOfDigits += digit;
                i /= 10;
            }

            return sumOfDigits % 8 == 0;

        }

        static bool OneOddDigit(int i)
        {

            while (i > 0)
            {
                int digit = i % 10;
                i /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }

            return false;

        }
    }
}
