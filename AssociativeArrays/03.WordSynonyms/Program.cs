class Programm
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> wordSynonyms = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!wordSynonyms.ContainsKey(word))
            {
                wordSynonyms[word] = synonym;
            }
            else
            {
                wordSynonyms[word] += ", " + synonym;
            }
        }

        foreach (KeyValuePair<string,string> kvp in wordSynonyms)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}