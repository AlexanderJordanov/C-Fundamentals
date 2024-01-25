/*
//Th1s 1s my str1ng!//
Change 1 i
Includes string
End my
Uppercase
FindIndex I
Cut 5 5
Done

*S0ftUni is the B3St Plac3**
Change 2 o
Includes best
End is
Uppercase
FindIndex P
Cut 3 7
Done
 */
class Programm
{
    static void Main()
    {
        string message = Console.ReadLine();

        string input = default;
        while ((input = Console.ReadLine()) != "Done")
        {
            string[] commandArgs = input.Split();
            string command = commandArgs[0];

            if (command == "Change")
            {
                string symbol = commandArgs[1];
                string replacement = commandArgs[2];
                message = message.Replace(symbol, replacement);
                Console.WriteLine(message);
            }
            else if(command == "Includes")
            {
                string substring = commandArgs[1];
                Console.WriteLine(message.Contains(substring));
            }
            else if (command == "End")
            {
                string substring = commandArgs[1];
                Console.WriteLine(message.EndsWith(substring));
            }
            else if (command == "Uppercase")
            {
                message = message.ToUpper();
                Console.WriteLine(message);
            }
            else if (command == "FindIndex")
            {
                string symbol = commandArgs[1];
                Console.WriteLine(message.IndexOf(symbol));
            }
            else if (command == "Cut")
            {
                int startIndex = int.Parse(commandArgs[1]);
                int count = int.Parse(commandArgs[2]);

                string middlePart = message.Substring(startIndex, count);
                
                Console.WriteLine($"{middlePart}");
            }
        }

    }
}