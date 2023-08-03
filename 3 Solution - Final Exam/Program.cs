// See https://aka.ms/new-console-template for more information
List<Hero> heroes = new List<Hero>();
string entr = string.Empty;
while((entr = Console.ReadLine()) != "End") 
{
    string[] tempEntr = entr.Split(" ");
    string command = tempEntr[0];
    string name = tempEntr[1];
    Hero heroFound = heroes.Find(x => x.Name == name);
    if (command == "Enroll")
    {
        if (heroFound == null)
        {
            List<string> spelName = new List<string>();
            heroes.Add(new Hero(name, spelName));
        }
        else
        {
            Console.WriteLine($"{heroFound.Name} is already enrolled.");
        }
    }
    else if (command == "Learn")
    {
        string spelName = tempEntr[2];
        if (heroFound != null)
        {
            Hero foundSpel = heroes.FirstOrDefault(x => x.SpelName.Contains(spelName));
            if (foundSpel != null)
            {
                Console.WriteLine($"{heroFound.Name} has already learnt {spelName}.");
            }
            else
            {
                heroFound.SpelName.Add(spelName);
            }
        }
        else
        {
            Console.WriteLine($"{name} doesn't exist.");
        }
    }
    else if (command == "Unlearn") 
    {
        string spelNameUnl = tempEntr[2];
        if (heroFound != null)
        {
            Hero foundSpelUnl = heroes.FirstOrDefault(x => x.SpelName.Contains(spelNameUnl));
            if (foundSpelUnl != null)
            {
                heroFound.SpelName.Remove(spelNameUnl);
            }
            else
            {
                Console.WriteLine($"{heroFound.Name} doesn't know {spelNameUnl}.");
            }
        }
        else 
        {
            Console.WriteLine($"{name} doesn't exist.");
        }
    }
}
Console.WriteLine("Heroes:");
foreach (Hero invetory in heroes) 
{
    Console.WriteLine($"== {invetory.Name}: {string.Join(", ", invetory.SpelName)}");
}
class Hero 
{
    public Hero(string name, List<string> spelName)
    {
        Name = name;
        SpelName = spelName;
    }

    public string Name { get; set; }
    public List<string> SpelName { get; set; }
}

