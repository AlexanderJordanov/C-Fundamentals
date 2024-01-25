class Programm
{
    static void Main()
    {
        string word = Console.ReadLine();
        Dictionary<char, int> charOccurances = new Dictionary<char, int>();

        for (int i = 0; i < word.Length; i++)
        {
            char currentChar = word[i];

            if (currentChar == ' ')
            {
                continue;
            }
           
            if (!charOccurances.ContainsKey(currentChar))
            {
                charOccurances.Add(currentChar, 0);
            }

            charOccurances[currentChar]++;
        }

        foreach (var kvp in charOccurances)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

}