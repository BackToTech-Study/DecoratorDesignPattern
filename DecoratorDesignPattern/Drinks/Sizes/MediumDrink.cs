namespace DecoratorDesignPattern.Drinks.Sizes;

//Concrete Implementation
public class MediumDrink : IDrinkSize
{
    public string Name => "Medium";
    public long Quantity => 300;
    public string Measure => "ml";
}