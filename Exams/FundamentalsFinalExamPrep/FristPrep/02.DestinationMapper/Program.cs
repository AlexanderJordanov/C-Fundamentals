using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*
=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=
 */
class Programm
{
    static void Main()
    {
        string decryptedPlaces = Console.ReadLine();
        string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

        MatchCollection matches = Regex.Matches(decryptedPlaces, pattern);

        List<string> places = new List<string>();

        foreach (Match match in matches)
        {
            string currentPlace = match.Groups["location"].Value;
            places.Add(currentPlace);
        }

        int totalPoints = 0;
        for (int i = 0; i < places.Count; i++)
        {
            totalPoints += places[i].Length;
        }

        Console.WriteLine($"Destinations: " + string.Join(", ", places));
        Console.WriteLine($"Travel Points: {totalPoints}");
    }

}
