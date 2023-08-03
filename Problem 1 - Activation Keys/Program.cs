// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Globalization;

string searched = Console.ReadLine();
string entr = string.Empty;
while ((entr = Console.ReadLine()) != "Generate") 
{
    string[] tempEntr = entr.Split(">>>");
    string command = tempEntr[0];
    if (command == "Contains")
    {
        string subString = tempEntr[1];
        if (searched.Contains(subString))
        {
            Console.WriteLine($"{searched} contains {subString}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (command == "Flip") 
    {
        string direction = tempEntr[1];
        int sIndex = int.Parse(tempEntr[2]);
        int eIndex = int.Parse(tempEntr[3]);
        eIndex = eIndex - 1;
        int sLength = searched.Length;
        string firstString = searched.Substring(0, sIndex);
        string workString = searched.Substring(sIndex, eIndex);
        string secondString = searched.Substring(eIndex);
        if (direction == "Upper" && CheckIndex(sIndex, eIndex, sLength)) 
        {
            workString = workString.ToUpper();
            searched = firstString + workString + secondString;
        }
    }
}
static bool CheckIndex(int sIndex, int eIndex, int sLength) 
{
    if (sIndex >= 0 && sIndex < sLength - 1 && eIndex > 0 && eIndex <= sLength - 1)
    {
        return true;
    }
    else 
    {
        return false;
    }
}
