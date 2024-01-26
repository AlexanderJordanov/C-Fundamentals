using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int comparison = GetMax(a , b);
                Console.WriteLine(comparison);
                
            }
            else if (type == "char") 
            { 
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char comparison = GetMax(a ,b);
                Console.WriteLine(comparison);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string comparison = GetMax(a, b);
                Console.WriteLine(comparison);
            }
        }

        static int GetMax(int a, int b)
        {
            
            if (a > b) 
            {
                return a;
            }
            else
            { 
                return b; 
            }
            
        }
        static char GetMax(char a, char b) 
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static string GetMax(string a, string b)
        {
                int comparison = a.CompareTo(b);
                if (comparison > 0)
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
