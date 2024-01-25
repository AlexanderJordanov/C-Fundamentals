class Programm
{

/*
10 20 30 40 50
50 40 30 30 10
*/
    static void Main()
    {
        List<int> firstPlayerDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> secondPlayerDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
        {
            int firstPlayerCard = firstPlayerDeck[0];
            int secondPlayerCard = secondPlayerDeck[0];

            if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
                firstPlayerDeck.Add(secondPlayerCard);
                firstPlayerDeck.Add(firstPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
                secondPlayerDeck.Add(firstPlayerCard);
                secondPlayerDeck.Add(secondPlayerCard);
            }
            else
            {
                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
            }
        }

        if (firstPlayerDeck.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {GetSum(firstPlayerDeck)}");
        }
        else if (secondPlayerDeck.Count > 0)
        {
            Console.WriteLine($"Second player wins! Sum: {GetSum(secondPlayerDeck)}");
        }
    }

    private static int GetSum(List<int> firstPlayerDeck)
    {
        int sum = 0;
        foreach (int card in firstPlayerDeck)
        {
            sum += card;
        }
        return sum;
    }
}