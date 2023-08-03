// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;
using System.Data.SqlTypes;
using System.Numerics;

string map = Console.ReadLine();
string entr = string.Empty;
while ((entr = Console.ReadLine()) != "Travel") 
{
    string[] tempEntr = entr.Split(":");
    string command = tempEntr[0];
    if (command == "Add Stop")
    {
        int index = int.Parse(tempEntr[1]);
        string insString = tempEntr[2];
        int mapLength = map.Length;
        if (index >= 0 && index <= mapLength - 1)
        {
            map = map.Insert(index, insString);
        }
    }

    else if (command == "Remove Stop")
    {
        int sIndex = int.Parse(tempEntr[1]);
        int eIndex = int.Parse(tempEntr[2]);
        int mapLength = map.Length;
        if (sIndex >= 0 && sIndex <= mapLength - 1 && eIndex >= 0 && eIndex <= mapLength - 1)
        {
            int stringLength = (eIndex - sIndex) + 1;
            map = map.Remove(sIndex, stringLength);
        }
    }
    else if (command == "Switch") 
    {
        string oString = tempEntr[1];
        string nString = tempEntr[2];
        if (map.Contains(oString)) 
        {
            map = map.Replace(oString, nString);
        }
    }
    Console.WriteLine(map);
}
Console.WriteLine($"Ready for world tour! Planned stops: {map}");