
namespace AbstractFactory
{
    public class PizzeriaColombiana: Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaColombiana();
        }
    }
}
