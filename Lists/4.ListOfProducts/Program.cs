using System;
using System.Collections.Generic;

namespace _4.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> orderedArray = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string products = Console.ReadLine();

                orderedArray.Add(products);
            }

            orderedArray.Sort();
           
            for (int i = 0;i < orderedArray.Count;i++)
            {
                Console.WriteLine($"{i+1}.{orderedArray[i]}");
            }
        }
    }
}