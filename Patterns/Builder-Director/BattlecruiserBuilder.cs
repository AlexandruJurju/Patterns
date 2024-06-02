namespace Builder_Director;

public class BattlecruiserBuilder : IBuilder
{
    private readonly Ship _ship = new();

    public void BuildShipModel()
    {
        _ship.Model = "Battlecruiser";
    }

    public void BuildShipSize()
    {
        _ship.Size = "Big";
    }

    public void BuildShipHp()
    {
        _ship.Hp = 250;
    }

    public void BuildShipDps()
    {
        _ship.Dps = 30;
    }

    public Ship Build()
    {
        return _ship;
    }
}