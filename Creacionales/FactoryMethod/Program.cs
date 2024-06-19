namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.VINO_TINTO);
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}