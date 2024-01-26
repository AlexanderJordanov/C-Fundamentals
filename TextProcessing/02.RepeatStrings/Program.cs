using System.Text;

class Programm 
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                sb.Append(word);
            }
        }

        Console.WriteLine(sb.ToString());
    }

}
