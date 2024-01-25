using System.Text.RegularExpressions;
/*
3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##

6
@###Val1d1teM@###
@#ValidIteM@#
##InvaliDiteM##
@InvalidIteM@
@#Invalid_IteM@#
@#ValiditeM@#
   
 */
class Programm
{
    static void Main()
    {
        string pattern = @"\@\#+(?<Barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string text = Console.ReadLine();

            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                string barcode = match.Groups["Barcode"].Value;
                string product = default;

                for (int j = 0; j < barcode.Length; j++)
                {
                    if (char.IsDigit(barcode[j]))
                    {
                        product += barcode[j];
                    }
                }

                if (product != null)
                {
                    Console.WriteLine($"Product group: {product}");
                }
                else
                {
                    Console.WriteLine($"Product group: 00");
                }
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
        }
    }

}