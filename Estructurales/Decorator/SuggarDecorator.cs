
namespace Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
    }
}
