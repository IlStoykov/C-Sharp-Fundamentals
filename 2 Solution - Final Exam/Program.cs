// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

int rounds = int.Parse(Console.ReadLine());
string pattern = @"(\!)(?<command>[A-Z][a-z]{2,})(\1)\:\[(?<message>[A-Za-z]{8,})\]";
List<int> intResult = new List<int>();

for (int i = 0; i < rounds; i++) 
{
    string entr = Console.ReadLine();
    var match = Regex.Match(entr, pattern);
    if (!match.Success)
    {
        Console.WriteLine("The message is invalid");
    }
    else 
    {
        string result = match.Groups["message"].Value;
        string command = match.Groups["command"].Value;
        foreach (char val in result)         
        {
            intResult.Add((int)val);
        }
        Console.WriteLine($"{command}: {string.Join(" ", intResult.ToArray())}");
    }
}