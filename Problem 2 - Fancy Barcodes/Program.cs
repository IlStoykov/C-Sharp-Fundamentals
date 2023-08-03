// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

int product = -1;
string workString = string.Empty;
int round = int.Parse(Console.ReadLine());
string pattern = @"\@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]\@\#+";
string dPattern = @"\d";
for (int i = 0; i < round; i++) 
{
    string entr = Console.ReadLine();
    Match match = Regex.Match(entr, pattern);

    if (Regex.IsMatch(entr, pattern) == false)
    {
        Console.WriteLine("Invalid barcode");
        continue;
    }
    else 
    {        
        foreach(Match matches in Regex.Matches(entr, dPattern))
        {
            workString +=(matches.Value);
        }
    }
    if (string.IsNullOrEmpty(workString)) 
    {
        Console.WriteLine("Product group: 00");
    }
    else
    {
        product = int.Parse(workString);        
        Console.WriteLine($"Product group: {product}");
    }
    workString = string.Empty;
}
