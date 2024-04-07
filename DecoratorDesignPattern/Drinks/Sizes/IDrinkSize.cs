namespace DecoratorDesignPattern.Drinks.Sizes;

//Implementation interface
public interface IDrinkSize
{
    public string Name { get; }
    public long Quantity { get; }
    public string Measure { get; }
}