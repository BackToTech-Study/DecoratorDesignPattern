namespace DecoratorDesignPattern;

//Decorator
public abstract class MealItem : IMeal
{
    protected IMeal _meal;
    protected List<string> _content = new();
    public IReadOnlyList<string> Content => _content.AsReadOnly();
    public abstract string Quantity { get; }
    public abstract double GetPrice();
    
    public MealItem(string name, IMeal meal)
    {
        _meal = meal;
        _content.AddRange(meal.Content);
        _content.Add(name);
    }
}