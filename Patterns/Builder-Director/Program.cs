namespace Builder_Director;

/// <summary>
/// When objects initialized using builder share some similarity, EX: all bugatti cars share the same attributes
/// The repeated code should be extracted to a separate class - Director
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        IBuilder battlecruiserBuilder = new BattlecruiserBuilder();
        Director director = new Director(battlecruiserBuilder);
        director.MakeShip();

        Ship ship = director.GetShip();

        Console.WriteLine(ship.Model);
        Console.WriteLine(ship.Size);
        Console.WriteLine(ship.Hp);
        Console.WriteLine(ship.Dps);
    }
}