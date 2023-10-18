namespace TroopsUnification;
class Program
{
    static void Main(string[] args)
    {
        string letter = "Б";
        
        List<Soldier> alphaSquad = new List<Soldier>
        {
            new("Пакман"),
            new("Биг Босс"),
            new("БТ-7274"),
            new("Гордон Фриман"),
            new("Пирамидоголовый"),
            new ("Лара Крофт")
        };
        List<Soldier> bravoSquad = new List<Soldier>
        {
            new("Боузер"),
            new("Байсон М.")
        };
        
        Console.WriteLine("  Отряд Альфа до:");
        ShowNames(alphaSquad);
        
        Console.WriteLine("\n  Отряд Браво до:");
        ShowNames(bravoSquad);
        
        var bNamedSoldiers = alphaSquad.Where(soldier => soldier.Name.StartsWith(letter)).ToList();
        bravoSquad = bravoSquad.Concat(bNamedSoldiers).ToList();
        alphaSquad = alphaSquad.Except(bNamedSoldiers).ToList();
        
        Console.WriteLine("\n  Отряд Альфа после:");
        ShowNames(alphaSquad);
        
        Console.WriteLine("\n  Отряд Браво после:");
        ShowNames(bravoSquad);
    }

    private static void ShowNames(List<Soldier> soldiers)
    {
        foreach (Soldier soldier in soldiers)
            Console.WriteLine(soldier.Name);
    }
}

class Soldier
{
    public Soldier(string name)
    {
        Name = name;
    }
    
    public string Name { get; private set; }
}
