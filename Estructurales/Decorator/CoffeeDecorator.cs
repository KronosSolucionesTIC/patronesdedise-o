
namespace Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _decoratedCoffee;

        public CoffeeDecorator(ICoffee decoratedCoffee)
        {
            _decoratedCoffee = decoratedCoffee;
        }

        public virtual string GetDescription()
        {
            return _decoratedCoffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _decoratedCoffee.GetCost();
        }
    }

}
