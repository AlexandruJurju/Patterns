namespace Builder_Director;

// the alternative to using the IBuilder would be to make the director have a method for creating each type of ship
// public Ship MakeBattleShip, MakeFlagship, Make ScoutShip
// !!! THIS WOULD BREAK SRP AND OCP !!!


// SRP 
    // If the Director class contained methods for creating each type of ship (e.g., MakeBattleShip, MakeFlagship, MakeScoutShip), it would have multiple responsibilities:
        // Managing the construction process of ships
        // Knowing the details of how each type of ship is constructed
    // This violates SRP because the Director would be responsible for both the process and the specific construction details of each ship type
    // Any change in the construction details of a particular ship type would require modifying the Director class

// FIX:
    // By using the IBuilder interface, the Director class delegates the responsibility of knowing how to build specific parts of the ship to the builder implementations
    // The Director class's only responsibility is to manage the construction process by orchestrating the builder. Thus, it adheres to SRP



// OCP - when adding a new type of ship Director would have to be changed
    // If the Director class contained methods like MakeBattleShip, MakeFlagship, and MakeScoutShip, adding a new type of ship (e.g., MakeCargoShip) would require
    // modifying the Director class to add a new method for this new ship type

    // This violates OCP because every time a new ship type is introduced, the Director class needs to be changed
    // This constant modification can lead to increased chances of introducing bugs and makes the code less maintainable

// FIX:
    // By using the interface IBuilder the Director class doesn't need to change when a new ship type is added, the new concrete class that implement the interface
    // does all the work for the new ship type
public class Director
{
    private readonly IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public Ship GetShip()
    {
        return _builder.Build();
    }

    public void MakeShip()
    {
        _builder.BuildShipModel();
        _builder.BuildShipSize();
        _builder.BuildShipDps();
        _builder.BuildShipHp();
    }
}