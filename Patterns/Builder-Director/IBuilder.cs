namespace Builder_Director;

public interface IBuilder
{
    void BuildShipModel();
    void BuildShipSize();
    void BuildShipHp();
    void BuildShipDps();
    Ship Build();
}