List<int> number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

SortedDictionary<int, int> numberOccurences = new SortedDictionary<int, int>();

for (int i = 0; i < number.Count; i++)
{
    int currentNumber = number[i];
    if (!numberOccurences.ContainsKey(currentNumber))
    {
        numberOccurences[currentNumber] = 1;
    }
    else
    {
        numberOccurences[currentNumber]++;
    }
}

foreach (KeyValuePair<int,int> kvp in numberOccurences)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}
