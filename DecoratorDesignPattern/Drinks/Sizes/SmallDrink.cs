namespace DecoratorDesignPattern.Drinks.Sizes;

//Concrete Implementation
public class SmallDrink : IDrinkSize
{
    public string Name => "Small";
    public long Quantity => 200;
    public string Measure => "ml";
}