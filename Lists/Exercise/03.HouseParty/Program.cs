int maxGuests = int.Parse(Console.ReadLine());
List<string> guests = new List <string>();


for (int i = 0; i < maxGuests; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string nameOfGuest = arguments[0];

    if (arguments[2] == "going!")
    {
        if (guests.Contains(nameOfGuest))
        {
            Console.WriteLine($"{nameOfGuest} is already in the list!");
        }
        else
        {
            guests.Add(nameOfGuest);
        }
    }
    else if (arguments[2] == "not")
    {
        if (guests.Contains(nameOfGuest))
        {
            guests.Remove(nameOfGuest);
        }
        else
        {
            Console.WriteLine($"{nameOfGuest} is not in the list!");
        }
    }
}
Console.WriteLine(string.Join("\n", guests));