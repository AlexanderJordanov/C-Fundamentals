/*
3
##>00|no|NO|!!!?<###
##>123|yes|YES|!!!<##
$$<111|noo|NOPE|<<>$$
 */

using System.Text.RegularExpressions;

class Programm
{
    static void Main()
    {
        string pattern =
            @"(.+)\>(?<numbers>[0-9]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^\>\<]{3})\<(\1)";

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, pattern) == false)
            {
                Console.WriteLine("Try another password!");
            }
            else
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                string result = (match.Groups["numbers"].Value + match.Groups["lower"].Value + match.Groups["upper"].Value + match.Groups["symbols"].Value).ToString();
                Console.WriteLine($"Password: {result}");
            }
        }
    }
}