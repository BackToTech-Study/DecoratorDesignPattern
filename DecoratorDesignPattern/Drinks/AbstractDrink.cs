using DecoratorDesignPattern.Drinks.Sizes;

namespace DecoratorDesignPattern.Drinks;

//Abstraction
public class BaseDrink : MealItem
{
    private string _name { get; } = "";
    private double _unitPrice { get; } = 0;
    private readonly IDrinkSize _size;
    
    protected BaseDrink(string name, double unitPrice, IDrinkSize size, IMeal meal) 
        : base(name, meal)
    {
        _name = name;
        _unitPrice = unitPrice;
        _size = new SmallDrink();
    }
    
    public override string Quantity => $"{_size.Quantity} {_size.Measure}";
    public override double GetPrice()
    {
        return _unitPrice * _size.Quantity + _meal.GetPrice();
    }
}