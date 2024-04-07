namespace DecoratorDesignPattern;

//ConcreteComponent
public class Meal : IMeal
{
    private const double ServiceCost = 1.0;
    public IReadOnlyList<string> Content => new List<string>();
    
    public double GetPrice()
    {
        return ServiceCost;
    }
}