using System.Text;

class Programm
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder cipheredText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char originalChar = text[i];

            cipheredText.Append((char)(originalChar+3));
        }

        Console.WriteLine(cipheredText);
    }

}