public class Singleton
{
    private static Singleton instance;

    private Singleton() { } //Al dejar private el constructor, se asegura que solo halla una instancia

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is doing something.");
    }
}
