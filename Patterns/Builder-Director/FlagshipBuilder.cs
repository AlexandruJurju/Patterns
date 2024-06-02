namespace Builder_Director;

public class FlagshipBuilder : IBuilder
{
    private readonly Ship _ship = new();

    public void BuildShipModel()
    {
        _ship.Model = "Flagship";
    }

    public void BuildShipSize()
    {
        _ship.Size = "Gigantic";
    }

    public void BuildShipHp()
    {
        _ship.Hp = 750;
    }

    public void BuildShipDps()
    {
        _ship.Dps = 90;
    }

    public Ship Build()
    {
        return _ship;
    }
}