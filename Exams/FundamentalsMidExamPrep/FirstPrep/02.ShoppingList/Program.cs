using System.Collections.Generic;

class Programm
{
    static void Main()
    {
        int peopleWaiting = int.Parse(Console.ReadLine());

        List<int> peopleInWagons = Console.ReadLine()
            .Split()
            .Select(int.Parse) 
            .ToList();


        for (int i = 0; i < peopleInWagons.Count; i++) 
        { 
            if (peopleInWagons[i] < 4)
            {
                if (peopleWaiting >= 4 - peopleInWagons[i])
                {
                    peopleWaiting -= 4 - peopleInWagons[i];
                    peopleInWagons[i] = 4;
                }
                else
                {
                    peopleInWagons[i] += peopleWaiting;
                    peopleWaiting = 0;
                }
            }
        }

        bool isNotFull = false;

        for (int i = 0; i < peopleInWagons.Count; i++)
        {
            if (peopleInWagons[i] < 4)
            {
                isNotFull = true;
                break;
            }
        }

        if (peopleWaiting == 0 && isNotFull)
        {
            Console.WriteLine("The lift has empty spots!");
        }
        else if (peopleWaiting > 0 && !isNotFull)
        {
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
        }
        Console.WriteLine(string.Join(" ", peopleInWagons));
    }
}