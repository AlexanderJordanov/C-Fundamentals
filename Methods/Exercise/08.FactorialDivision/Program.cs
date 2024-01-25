using System;
using System.Collections.Generic;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factoriel(firstNumber) / Factoriel(secondNumber)):f2}");
        }

        static double Factoriel (long num)
        {
            double result = 1;

            for (long i = 1; i <= num; i++) 
            { 
                result *= i;
            }
            return result;
        }
    }
}
