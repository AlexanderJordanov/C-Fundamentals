class Programm
{
    static void Main()
    {
        string text = Console.ReadLine();
        string result = RemoveRepeatedCharaters(text);
        Console.WriteLine (result);
    }

    private static string RemoveRepeatedCharaters(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        string result = text[0].ToString();

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                result += text[i];
            }
        }

        return result;
    }
}