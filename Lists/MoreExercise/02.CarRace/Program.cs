/* 
[29 13 9 0 13 0 21 0 14 82 12]
 */


List< int > race = Console.ReadLine()//double?
    .Split()
    .Select(int.Parse)
    .ToList();

double firstRacer = 0;
double secondRacer = 0;

for (int i = 0; i < race.Count / 2; i++)
{
    firstRacer += race[i];

    if (race[i] == 0)
    {
        firstRacer *= 0.8;
    }
}

for (int i = race.Count - 1; i > race.Count / 2; i--)
{
    secondRacer += race[i];

    if (race[i] == 0)
    {
        secondRacer *= 0.8;
    }
}

if (firstRacer > secondRacer)
{
    Console.WriteLine($"The winner is right with total time: {Math.Round(secondRacer, 1)}");
}
else
{
    Console.WriteLine($"The winner is left with total time: {Math.Round(firstRacer, 1)}");
}