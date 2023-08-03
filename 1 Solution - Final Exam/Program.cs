// See https://aka.ms/new-console-template for more information
string workStr = Console.ReadLine();
string entr = string.Empty;
while ((entr = Console.ReadLine()) != "Done") 
{
    string[] tempEntr = entr.Split(" ");
    string command = tempEntr[0];
    if (command == "Change")
    {
        string oStr = tempEntr[1];
        string nStr = tempEntr[2];
        workStr = workStr.Replace(oStr, nStr);
        Console.WriteLine(workStr);
    }
    else if (command == "Includes")
    {
        string checkStr = tempEntr[1];
        if (workStr.Contains(checkStr))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else if (command == "End")
    {
        string endStr = tempEntr[1];
        if (workStr.EndsWith(endStr))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else if (command == "Uppercase")
    {
        workStr = workStr.ToUpper();
        Console.WriteLine(workStr);

    }
    else if (command == "FindIndex")
    {
        string searched = tempEntr[1];
        int index = workStr.IndexOf(searched);
        if (index > -1)
        {
            Console.WriteLine(index);
        }
    }
    else if (command == "Cut") 
    {
        int sIndex = int.Parse(tempEntr[1]);
        int count = int.Parse(tempEntr[2]);
        string result = workStr.Substring(sIndex, count);
        Console.WriteLine(result);
        workStr = workStr.Remove(sIndex, count);
    }
}
