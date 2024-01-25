
/*
Iron, Wood, Sword
Collect - Gold
Drop - Wood
Craft!
 */


List<string> materials = Console.ReadLine()
    .Split(", ")
    .ToList();

string input = default;
while ((input = Console.ReadLine()) != "Craft!")
{
    string[] arguments = input.Split();
    string command = arguments[0];

    if (command == "Collect")
    {
        string item = arguments[2];
        if (materials.Exists(x => x == item))
        {
            break;
        }
        else
        {
            materials.Add(item);
        }
    }
    else if (command == "Drop")
    {
        string item = arguments[2];

        if (materials.Exists(x => x == item))
        {
            materials.Remove(item);
        }

    }
    else if (command == "Combine")
    {
        string[] oldNewItems = arguments[3].Split(":");
        string oldItem = oldNewItems[0];
        string newItem = oldNewItems[1];

            if (materials.Exists(x => x == oldItem))
            {
                int oldItemIndex = materials.IndexOf(oldItem);
                materials.Insert(oldItemIndex + 1, newItem);
            }
    }
    else if (command == "Renew")
    {
        string item = arguments[2];

            if (materials.Exists(x => x == item))
            {
                materials.Remove(item);
                materials.Add(item);
            }
    }
}

Console.WriteLine(string.Join(", ", materials));