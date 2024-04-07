using DecoratorDesignPattern.Drinks.Sizes;

namespace DecoratorDesignPattern.Drinks;

//Concrete Decorator
//Refined Abstraction
public class Coke : BaseDrink
{
    public Coke(IDrinkSize size, IMeal meal) 
        : base("Coke", 0.09, size, meal)
    { }
}