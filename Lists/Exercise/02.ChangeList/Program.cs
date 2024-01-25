/*
1 2 3 4 5 5 5 6
Delete 5
Insert 10 1
Delete 5
end
*/



using System.Data;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();


string input = default;
while ((input = Console.ReadLine()) != "end")
{
    string[] arguments = input.Split();
    string command = arguments[0];
    if (command == "Delete")
    {
        int element = int.Parse(arguments[1]);
        list.Remove(element);
    }
    else if (command == "Insert")
    {
        int index = int.Parse(arguments[2]);
        int number = int.Parse(arguments[1]);

        list.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", list));

