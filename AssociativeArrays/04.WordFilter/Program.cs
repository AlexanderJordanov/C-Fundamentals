using System;
using System.Collections.Generic;
using System.Linq;

class Programm
{
    //kiwi orange banana apple
    static void Main()
    {
        Console.WriteLine(string.Join("\n", Console.ReadLine()
            .Split()
            .Where(x => x.Count() % 2 == 0)
            .ToList()));
    }

}