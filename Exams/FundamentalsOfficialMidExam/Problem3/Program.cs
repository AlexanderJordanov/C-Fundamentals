class Programm
{
    static void Main()
    {/*
SamsungA50, MotorolaG5, IphoneSE
Add - Iphone10
Remove - IphoneSE
End

HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiaomiNote:Iphone5
End
         */
        List <string> phones = Console.ReadLine().Split(", ").ToList();
        string input = default;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split(" - ");
            string command = arguments[0];
            if (command == "Add")
            {
                string newPhone = arguments[1];

                if (phones.Exists(x => x == newPhone))
                {
                    continue;
                }
                else
                {
                    phones.Add(newPhone);
                }
            }
            else if (command == "Remove")
            {
                string oldPhone = arguments[1];
                if (phones.Exists(x => x == oldPhone))
                {
                    phones.Remove(oldPhone);
                }
            }
            else if (command == "Bonus phone")
            {
                string[] oldAndNewPhone = arguments[1].Split(":");
                string oldPhone = oldAndNewPhone[0];
                string newPhone = oldAndNewPhone[1];

                for (int i = 0; i < phones.Count; i++)
                {
                    if (phones[i].Equals(oldPhone))
                    {
                        phones.Insert(i+1, newPhone);
                    }
                }
            }
            else if (command == "Last")
            {
                string phone = arguments[1];
                for (int i = 0; i < phones.Count; i++)
                {
                    if (phones[i].Equals(phone))
                    {
                        phones.RemoveAt(i);
                        phones.Add(phone);
                    }
                }
            }
        }
        Console.WriteLine(string.Join(", ", phones));
        
    }

}