using System;

namespace AbstractFactory
{
    public class PizzeriaItaliana: Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}
