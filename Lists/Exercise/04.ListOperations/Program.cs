/*
5 12 42 95 32 1
Insert 3 0
Remove 10
Insert 8 6
Shift right 1
Shift left 2
End
*/

class Programm
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] operations = input.Split();
            string command = operations[0];

            if (command == "Add")
            {
                int number = int.Parse(operations[1]);
                list.Add(number);
            }
            else if (command == "Insert")
            {
                int number = int.Parse(operations[1]);
                int index = int.Parse(operations[2]);

                if (isNotValidIndex(index, list.Count))
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    list.Insert(index, number);
                }
            }
            else if (command == "Remove")
            {
                int index = int.Parse(operations[1]);

                if (isNotValidIndex(index, list.Count))
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    list.RemoveAt(index);
                }
            }
            else if (command == "Shift")
            {
                string direction = operations[1];
                int count = int.Parse(operations[2]);

                count %= list.Count;

                if (direction == "left")
                {
                    List<int> shiftedList = list.GetRange(0, count);
                    list.RemoveRange(0, count);
                    list.InsertRange(list.Count, shiftedList);
                }
                else if (direction == "right")
                {
                    List<int> shiftedList = list.GetRange(list.Count - count, count);
                    list.RemoveRange(list.Count - count, count);
                    list.InsertRange(0, shiftedList);
                }
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
    private static bool isNotValidIndex(int index, int listCount)
    {
        return index < 0 || index >= listCount;
    }
}



