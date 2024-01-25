/*
Hawai::Cyprys-Greece
Add Stop:7:Rome
Remove Stop:11:16
Switch:Hawai:Bulgaria
Travel
   
Albania:Bulgaria:Cyprus:Deuchland
Add Stop:3:Nigeria
Remove Stop:4:8
Switch:Albania: Azərbaycan
Travel
   
 */

using Console = System.Console;

class Programm
{
    static void Main()
    {
        string stops = Console.ReadLine();

        string input = default;
        while ((input = Console.ReadLine()) != "Travel")
        {
            string[] arguments = input.Split(":");
            string command = arguments[0];

            if (command == "Add Stop")
            {
                int index = int.Parse(arguments[1]);
                string destination = arguments[2];

                if (index >= 0 && index < stops.Length)
                {
                   stops = stops.Insert(index, destination);
                }
                Console.WriteLine(stops);
            }
            else if (command == "Remove Stop")
            {
                int startIndex = int.Parse(arguments[1]);
                int endIndex = int.Parse(arguments[2]);

                if ((startIndex >= 0 && startIndex < stops.Length) && (endIndex >= startIndex && endIndex < stops.Length))
                {
                    string firstPart = stops.Substring(0, startIndex);
                    string lastPart = stops.Substring(endIndex + 1);
                    stops = firstPart + lastPart;
                }

                Console.WriteLine(stops);
            }
            else if (command == "Switch")
            {
                string oldString = arguments[1];
                string newString = arguments[2];

                if (stops.Contains(oldString))
                {
                    stops = stops.Replace(oldString, newString);
                }

                Console.WriteLine(stops);
            }
        }

        Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
    }

}