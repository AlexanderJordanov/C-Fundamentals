using System.Runtime.InteropServices;

class Programm
{
    static void Main()
    {
        Dictionary<string, User> users = new Dictionary<string, User>();
        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string command = arguments[0];
            string userName = arguments[1];

            switch (command)
            {
                case "register":
                    string licensePlate = arguments[2];
                    User user = new User(userName, licensePlate);
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        users.Add(userName, user);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    break;
                case "unregister":
                    if (users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    break;
            }
        }

        foreach (KeyValuePair<string, User> kvp in users)
        {
            Console.WriteLine(kvp.Value);
        }
    }

    class User
    {
        public User(string username, string licensePlate)
        {
            Username = username;
            LicensePlate = licensePlate;
        }
        public string Username { get; set; }

        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{Username} => {LicensePlate}";
        }
    }
}