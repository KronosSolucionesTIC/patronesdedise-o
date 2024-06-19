using Decorator;

public class Program
{
    public static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} ${coffee.GetCost()}");

        coffee = new Decorator.MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} ${coffee.GetCost()}");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} ${coffee.GetCost()}");

        coffee = new Decorator.MilkDecorator(coffee); // Adding another milk
        Console.WriteLine($"{coffee.GetDescription()} ${coffee.GetCost()}");
    }
}
