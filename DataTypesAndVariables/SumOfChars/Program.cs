int amountOfChars = int.Parse(Console.ReadLine());
int sumOfChars = 0;

for (int i = 0; i < amountOfChars; i++)
{
    char letter = char.Parse(Console.ReadLine());
    sumOfChars += letter;
}

Console.WriteLine($"The sum equals: {sumOfChars}");

