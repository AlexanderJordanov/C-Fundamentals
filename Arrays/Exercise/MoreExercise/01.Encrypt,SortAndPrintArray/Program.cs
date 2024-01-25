using System;
using System.Collections.Immutable;
using System.Linq;

namespace _01.Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int [] array = new int[number];
    
            int sumVowels = 0;
            int sumConsonants = 0;
            int sum = 0;
            for (int i = 0; i < number; i++) 
            {
                string word = Console.ReadLine();
                
                for (int j = 0; j < word.Length; j++)
                {
                    char letter = word[j];
                    
                    if (letter == 65 || letter == 69 || letter == 73 || letter == 79 || letter == 85 || letter == 97 || letter == 101 || letter == 105 || letter == 111 || letter == 117)
                    {
                        sumVowels += letter * word.Length;
                    }
                    else
                    {
                        sumConsonants += letter / word.Length;
                    }
                }

                sum = sumVowels + sumConsonants;
                array[i] = sum;

                sumVowels = 0;
                sumConsonants = 0;
                sum = 0;
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           
        }
    }
}
