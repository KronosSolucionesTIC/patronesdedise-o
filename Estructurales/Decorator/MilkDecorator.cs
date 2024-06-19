
namespace Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }
    }
}
