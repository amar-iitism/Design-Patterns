#Step 1: Define the Component Interface
public interface ICoffee
{
    string GetDescription();
    double Cost();
}
// Step 2: Create Concrete Component Class
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double Cost()
    {
        return 1.00; // base price for simple coffee
    }
}
// Step 3: Create Decorator Abstract Class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract string GetDescription();
    public abstract double Cost();
}
// Step 4: Create Concrete Decorator Classes
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        return _coffee.Cost() + 0.50; // cost of milk
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Sugar";
    }

    public override double Cost()
    {
        return _coffee.Cost() + 0.20; // cost of sugar
    }
}

public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Whipped Cream";
    }

    public override double Cost()
    {
        return _coffee.Cost() + 0.70; // cost of whipped cream
    }
}
// Step 5: Client Code
class Program
{
    static void Main(string[] args)
    {
        // Create a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost()}");

        // Add milk to the coffee
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost()}");

        // Add sugar to the coffee
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost()}");

        // Add whipped cream to the coffee
        coffee = new WhippedCreamDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} costs {coffee.Cost()}");
    }
}


