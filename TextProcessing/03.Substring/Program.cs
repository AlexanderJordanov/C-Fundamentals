class Programm
{
    static void Main()
    {
        string filter = Console.ReadLine();
        string text = Console.ReadLine();

        while (text.Contains(filter))
        {
            text = text.Remove(text.IndexOf(filter), filter.Length);
        }
        Console.WriteLine(text);
    }

}