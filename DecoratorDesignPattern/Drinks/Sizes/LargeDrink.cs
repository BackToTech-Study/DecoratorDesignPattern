namespace DecoratorDesignPattern.Drinks.Sizes;

//Concrete Implementation
public class LargeDrink : IDrinkSize
{
    public string Name => "Large";
    public long Quantity => 500;
    public string Measure => "ml";
}