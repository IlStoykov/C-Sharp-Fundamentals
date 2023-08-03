// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

List<string> destinations = new List<string>();
int points = 0;
string pattern = @"([\=\/])(?<town>[A-Z][a-zA-Z]{2,})\1";
string entr = Console.ReadLine();
MatchCollection match = Regex.Matches(entr, pattern);
foreach (Match m in match) 
{
    if (m.Success) 
    {
        string city = m.Groups["town"].Value;
        int longest = city.Length;
        points += longest;
        destinations.Add(city);
    }

}
Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
Console.WriteLine($"Travel Points: {points}");
