namespace DecoratorDesignPattern.Garnishes;

//Concrete Decorator
public class Fires : MealItem
{
    public override string Quantity => "200 g";

    public override double GetPrice()
    {
        return 3.99 + _meal.GetPrice();
    }
    
    public Fires(IMeal meal) 
        : base("Fires", meal)
    { }
}