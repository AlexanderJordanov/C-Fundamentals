/*
1 1 2 2 3 3 4 4 5 5
1 0
-1 0
1 0
1 0
1 0
end


*/
class Programm
{
    static void Main()
    {
        List<string> sequence = Console.ReadLine()
            .Split()
            .ToList();

        bool hasWon = false;
        int movesCounter = 0;
        string input = default;
        while ((input = Console.ReadLine()) != "end")
        {
            int[] indexes = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            movesCounter++;

            if (firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= sequence.Count) ||
                (secondIndex < 0 || secondIndex >= sequence.Count))
            {
                string element = "-" + movesCounter + "a";
                int middleIndex = sequence.Count / 2;
                List<string> insertedElements = new List<string>() {element, element};
                sequence.InsertRange(middleIndex, insertedElements);
                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }

            else
            {

                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");

                    if (secondIndex > firstIndex)
                    {
                        sequence.RemoveAt(secondIndex);
                        sequence.RemoveAt(firstIndex);
                    }

                    else
                    {
                        sequence.RemoveAt(firstIndex);
                        sequence.RemoveAt(secondIndex);
                    }
                }

                else if (sequence[firstIndex] != sequence[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }

                if (sequence.Count == 0)
                {
                    hasWon = true;
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    break;
                }
            }
        }

        if (!hasWon)
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));
        }
      

    }

}