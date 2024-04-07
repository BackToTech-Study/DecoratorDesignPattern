namespace DecoratorDesignPattern;

//Component
public interface IMeal
{
    public IReadOnlyList<string> Content { get; }
    public double GetPrice();
}