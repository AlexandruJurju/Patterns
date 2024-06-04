using AbstractFactory_Simple.Products;

namespace AbstractFactory_Simple.Factory;


/// <summary>
/// Breaks OCP
/// Factory CreateComponent will have to change when a new component gets added
/// </summary>
public abstract class Factory
{
    public abstract IComponent CreateComponent(Product product);
}