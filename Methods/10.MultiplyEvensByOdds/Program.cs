using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = SumOfEvenDigits(number) * SumOfOddDigits(number);
            Console.WriteLine(result);
        }


        static int SumOfEvenDigits (int number)
        {
            int sumOfEvens = 0;

            while (number != 0)
            {
                int currentDigit = number % 10; 

                if (currentDigit % 2 == 0)
                {
                    sumOfEvens += currentDigit;
                }

                number /= 10;
            }
            return sumOfEvens;
        }

        static int SumOfOddDigits(int number)
        {
            int sumOfOdds = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 1)
                {
                    sumOfOdds += currentDigit;
                }

                number /= 10;
            }
            return sumOfOdds;
        }


    }
}
