using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        Pizzeria fabrica;
        fabrica = new PizzeriaColombiana();
        Pizza pizza = fabrica.CrearPizza();
        Console.WriteLine(pizza.Descripcion);

        fabrica = new PizzeriaItaliana();
        pizza = fabrica.CrearPizza();
        Console.WriteLine(pizza.Descripcion);
    }
}
