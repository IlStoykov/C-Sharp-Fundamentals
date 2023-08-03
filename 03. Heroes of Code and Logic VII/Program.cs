// See https://aka.ms/new-console-template for more information
int HEROPOINT = 100;
int HEROMANA = 200;
int participants = int.Parse(Console.ReadLine());
List<Hero> heroes = new List<Hero>();

for (int i = 0; i < participants; i++) 
{
    string[] entr = Console.ReadLine().Split(" ");
    heroes.Add(new Hero(entr[0], int.Parse(entr[1]), int.Parse(entr[2])));
}
string nextEntr = string.Empty;
while ((nextEntr = Console.ReadLine()) != "End")
{
    string[] tempCommand = nextEntr.Split(" - ");
    string command = tempCommand[0];
    string name = tempCommand[1];
    Hero foundHero = heroes.Find(x => x.Name == name);
    if (command == "CastSpell")
    {
        int hMana = int.Parse(tempCommand[2]);
        string spell = tempCommand[3];
        if (foundHero.Mana >= hMana)
        {
            foundHero.Mana -= hMana;
            Console.WriteLine($"{foundHero.Name} has successfully cast {spell} and now has {foundHero.Mana} MP!");
        }
        else
        {
            Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spell}!");
        }
    }
    else if (command == "TakeDamage")
    {
        int demage = int.Parse(tempCommand[2]);
        string attacer = tempCommand[3];
        if (foundHero.Point > demage)
        {
            foundHero.Point -= demage;
            Console.WriteLine($"{foundHero.Name} was hit for {demage} HP by {attacer} and now has {foundHero.Point} HP left!");
        }
        else
        {
            Console.WriteLine($"{foundHero.Name} has been killed by {attacer}!");
            heroes.Remove(foundHero);
        }
    }
    else if (command == "Recharge")
    {
        int recharge = int.Parse(tempCommand[2]);
        foundHero.Mana += recharge;
        
        if (foundHero.Mana > HEROMANA)
        {
            recharge = recharge - (foundHero.Mana - HEROMANA) ;
            foundHero.Mana = HEROMANA;                       
        }
        Console.WriteLine($"{foundHero.Name} recharged for {recharge} MP!");
    }
    else if (command == "Heal") 
    {
        int heal = int.Parse(tempCommand[2]);
        foundHero.Point += heal;
        
        if (foundHero.Point > HEROPOINT) 
        {
            heal = heal - (foundHero.Point - HEROPOINT);
            foundHero.Point = HEROPOINT;            
        }        
        Console.WriteLine($"{foundHero.Name} healed for {heal} HP!");

    }
}
foreach (Hero inventory in heroes) 
{
    Console.WriteLine($"{inventory.Name}");
    Console.WriteLine($"  HP: {inventory.Point}");
    Console.WriteLine($"  MP: {inventory.Mana}");
}
class Hero 
{
    public Hero(string name, int point, int mana)
    {
        Name = name;
        Point = point;
        Mana = mana;
    }

    public string Name { get; set; }
    public int Point { get; set; }
    public int Mana { get; set; }
}