class Programm
{
    static void Main()
    {
        string bigNumber = Console.ReadLine();
        string multiplier = Console.ReadLine();

        string product = MultipliNumbers(bigNumber, multiplier);
        Console.WriteLine(product);
    }

    private static string MultipliNumbers(string bigNumber, string multiplier)
    {
        if (bigNumber == "0" || multiplier == "0")
        {
            return "0";
        }

        int carry = 0;
        int multiply = int.Parse(multiplier);

        char[] resulted = new char[bigNumber.Length + 1];

        for (int i = bigNumber.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(bigNumber[i].ToString());

            int product = digit * multiply + carry;

            resulted[i + 1] = (char)((product % 10) + '0');

            carry = product / 10;
        }

        if (carry > 0)
        {
            resulted[0] = (char)((carry + '0'));
        }

        return new string(resulted).TrimStart('\0');
    }
}