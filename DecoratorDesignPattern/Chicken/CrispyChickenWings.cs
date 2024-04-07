namespace DecoratorDesignPattern.Chicken;

//Concrete Decorator
public class CrispyChickenWings : MealItem
{
    public override string Quantity => "150 g";

    public override double GetPrice()
    {
        return 5.99 + _meal.GetPrice();
    }
    
    public CrispyChickenWings(IMeal meal) 
        : base("Crispy Chicken Wings", meal)
    { }
}