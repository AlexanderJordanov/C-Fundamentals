class Programm
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(", ").ToArray();

        foreach (string user in text)
        {
            if (user.Length < 3 || user.Length > 16)
            {
                continue;
            }

            bool isValid = user.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_');

            if (isValid)
            {
                Console.WriteLine(user);
            }
        }
    }

}