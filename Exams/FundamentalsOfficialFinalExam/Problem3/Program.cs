/*
Like-Krisi-shrimps
Like-Krisi-soup
Like-Penelope-dessert
Like-Misho-salad
Stop

Like-Krisi-shrimps
Dislike-Vili-carp
Dislike-Krisi-salad
Stop
 */

using Console = System.Console;

class Guest
{
    public Guest(string name)
    {
        Name = name;
        Meals = new List<string>();
    }
    public string Name { get; set; }

    public List<string> Meals { get; set; }

    public override string ToString()
    {
        string result = $"{Name}: ";
        foreach (var meal in Meals)
        {
            result += meal + ", ";
        }

        if (result.EndsWith(", "))
        {
            result = result.Remove(result.LastIndexOf(", "));
        }
        return result;
    }
}
class Programm
{
    static void Main()
    {
        List<Guest> guests = new List<Guest>();
        string input = default;
        int dislikeMealsCounter = 0;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] guestArgs = input.Split("-");

            string command = guestArgs[0];
            string name = guestArgs[1];
            string meal = guestArgs[2];

            Guest guest = new Guest(name);
            Guest foundGuest = guests.FirstOrDefault(g => g.Name == name);
            if (command == "Like")
            {
                if (foundGuest == null)
                {
                    guests.Add(guest);
                    guest.Meals.Add(meal);
                }
                else
                {
                    if (foundGuest.Meals.Contains(meal))
                    {
                        continue;
                    }
                    else
                    {
                        foundGuest.Meals.Add(meal);
                    }
                }
            }
            else if (command == "Dislike")
            {
                if (foundGuest == null)
                {
                    Console.WriteLine($"{name} is not at the party.");
                    continue;
                }

                if (foundGuest.Meals.Contains(meal) == false)
                {
                    Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                    continue;
                }

                Console.WriteLine($"{name} doesn't like the {meal}.");
                foundGuest.Meals.Remove(meal);
                dislikeMealsCounter++;
            }
        }

        foreach (var guest in guests)
        {
            Console.WriteLine(guest);
        }
        Console.WriteLine($"Unliked meals: {dislikeMealsCounter}");
    }
}