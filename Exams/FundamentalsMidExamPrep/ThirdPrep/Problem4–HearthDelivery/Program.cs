List <int> neededHearts = Console.ReadLine()
    .Split("@")
    .Select(int.Parse)
    .ToList();

int currentPosotion = 0;
string input = default;
while ((input = Console.ReadLine()) != "Love!")
{
    string[] arguments = input.Split();

    if (arguments[0] == "Jump")
    {
        currentPosotion += int.Parse(arguments[1]);
    }

    if (currentPosotion >= neededHearts.Count)
    {
        currentPosotion = 0;
    }

    if (neededHearts[currentPosotion] == 0)
    {
        Console.WriteLine($"Place {currentPosotion} already had Valentine's day.");
    }
    else
    {
        neededHearts[currentPosotion] -= 2;

        if (neededHearts[currentPosotion] == 0)
        {
            Console.WriteLine($"Place {currentPosotion} has Valentine's day.");
        }
    }
}

Console.WriteLine($"Cupid's last position was {currentPosotion}.");

int counter = 0;

for (int i = 0; i < neededHearts.Count; i++)
{
    if (neededHearts[i] > 0)
    {
        counter ++;
    }
}

if (counter <= 0)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {counter} places.");
}
