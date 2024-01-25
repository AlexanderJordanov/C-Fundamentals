using System.Text.RegularExpressions;

class Programm
{
    class Message
    {
        public Message(string planetName, int population, string attackType, int soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }
        public string PlanetName { get; set; }
        public int Population { get; set; }
        public string AttackType { get; set; }
        public int SoldierCount { get; set; }

    }

    static void Main()
    {
        List<Message> messages = new List<Message>();

        string keyPattern = @"[SsTtAaRr]";
        string starPattern =
            @"\@(?<Name>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<Type>A|D)\![^\@\-\!\:\>]*\-\>(?<Soldiers>\d+)[^\@\-\!\:\>]*";

        int numberOfMessages = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfMessages; i++)
        {
            string encryptedMessage = Console.ReadLine();

            int key = Regex.Matches(encryptedMessage, keyPattern).Count();

            string decryptedMessage = String.Empty;
            for (int j = 0; j < encryptedMessage.Length; j++)
            {
                decryptedMessage += (char)(encryptedMessage[j] - key);
            }

            foreach (Match match in Regex.Matches(decryptedMessage, starPattern))
            {
                string planetName = match.Groups["Name"].Value;
                int polulation = int.Parse(match.Groups["Population"].Value);
                string attackType = match.Groups["Type"].Value;
                int soldiersCount = int.Parse(match.Groups["Soldiers"].Value);

                Message message = new Message(planetName, polulation, attackType, soldiersCount);
                messages.Add(message);
            }
        }

        var planets = messages.Where(p => p.AttackType == "A")
            .OrderBy(p => p.PlanetName)
            .ToList();
        Console.WriteLine($"Attacked planets: {planets.Count}");
        foreach (var planet in planets)
        {
            Console.WriteLine($"-> {planet.PlanetName}");
        }

        planets = messages.Where(p => p.AttackType == "D")
            .OrderBy(p => p.PlanetName)
            .ToList();
        Console.WriteLine($"Destroyed planets: {planets.Count}");
        foreach (var planet in planets)
        {
            Console.WriteLine($"-> {planet.PlanetName}");
        }
    }

}
