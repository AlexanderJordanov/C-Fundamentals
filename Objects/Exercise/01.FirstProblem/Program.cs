class Programm
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Random random = new Random();

        for (int i = 0; i < input.Length; i++)
        {
            int randomIndex = random.Next(input.Length);
            
            string currentWord = input[i];
            string randomWord = input[randomIndex];

            input[i] = randomWord;
            input[randomIndex] = currentWord;
        }

        foreach (string word in input)
        {
            Console.WriteLine(word);
        }
    }

}