string[] words = Console.ReadLine()
    .Split()
    .Select(x => x.ToLower())
    .ToArray();

Dictionary<string, int> wordOccurences = new Dictionary<string, int>();

for (int i = 0; i < words.Length; i++)
{
    string currrentWord = words[i];

    if (!wordOccurences.ContainsKey(currrentWord))
    {
        wordOccurences.Add(currrentWord, 0);
    }
    wordOccurences[currrentWord]++;
}

foreach (KeyValuePair<string,int> kvp in wordOccurences)
{
    if (kvp.Value % 2 == 1)
    {
        Console.Write($"{kvp.Key} ");
    }
}