namespace Builder_Director;

public class ScoutShipBuilder : IBuilder
{
    private readonly Ship _ship = new();

    public void BuildShipModel()
    {
        _ship.Model = "Scout";
    }

    public void BuildShipSize()
    {
        _ship.Size = "Small";
    }

    public void BuildShipHp()
    {
        _ship.Hp = 50;
    }

    public void BuildShipDps()
    {
        _ship.Dps = 10;
    }
    
    public Ship Build()
    {
        return _ship;
    }
}