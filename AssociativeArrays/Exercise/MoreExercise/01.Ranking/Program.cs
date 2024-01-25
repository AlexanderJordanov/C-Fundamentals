class Programm
{
/*

Part One Interview:success
Js Fundamentals:Jsfundmpass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One Interview=>success=>Nikola=>120
Java Basics Exam=>jsfundmpass=>Mary=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>Jim=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>Jsfundmpass=>Tanya=>400
end of submissions
   


Java Advanced:funpass
Part Two Interview:success
Math Concept:asdasd
Java Web Basics:forrF
end of contests
Math Concept=>ispass=>Mona=>290
Java Advanced=>funpass=>Simon=>400
Part Two Interview=>success=>Derek=>120
Java Advanced=>funpass=>Peter=>90
Java Web Basics=>forrF=>Simon=>280
Part Two Interview=>success=>Peter=>0
Math Concept=>asdasd=>Derek=>250
Part Two Interview=>success=>Simon=>200
end of submissions
   
*/
    static void Main()
    {
        Dictionary<string, string> contests = new Dictionary<string, string>();

        string input = default;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] contestArguments = input.Split(":");

            string contest = contestArguments[0];
            string password = contestArguments[1];

            contests.Add(contest, password);
        }

        Dictionary<string, Dictionary<string, int>> usersResults = new Dictionary<string, Dictionary<string,int>>();
        while ((input = Console.ReadLine()) != "end of submissions")
        {
            string[] userArguments = input.Split("=>");
            string contest = userArguments[0];
            string password = userArguments[1];
            string userName = userArguments[2];
            int points = int.Parse(userArguments[3]);

            if (contests.ContainsKey(contest) && contests[contest] == password)
            {
                if (!usersResults.ContainsKey(userName))
                {
                    usersResults.Add(userName, new Dictionary<string, int>());
                }

                if (!usersResults[userName].ContainsKey(contest))
                {
                    usersResults[userName].Add(contest, 0);
                }
                if (usersResults[userName][contest] < points)
                {
                    usersResults[userName][contest] = points;
                }
            }
        }

        string winner = usersResults.OrderBy(x => x.Value.Values.Sum()).Last().Key;

        int bestPoints = usersResults.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

        Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

        Console.WriteLine("Ranking: ");

        foreach (var item in usersResults.OrderBy(x => x.Key))
        {
            Console.WriteLine(item.Key);

            foreach (var contest in item.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }

}
