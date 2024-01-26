class Programm
{
    static void Main()
    {
        //string text = Console.ReadLine();

        //Console.WriteLine(new string(text.Where(x => char.IsDigit(x)).ToArray()));
        //Console.WriteLine(new string(text.Where(x => char.IsLetter(x)).ToArray()));
        //Console.WriteLine(new string(text.Where(x => !char.IsLetter(x) && !char.IsDigit(x)).ToArray()));



        char[] text = Console.ReadLine().ToCharArray();
        string digits = string.Empty;
        string letters = string.Empty;
        string other = string.Empty;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]))
            {
                digits += text[i];
            }
            else if (char.IsLetter(text[i]))
            {
                letters += text[i];
            }
            else
            {
                other += text[i];
            }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }

}