public class Program
{
    public static void Main(string[] args)
    {
        Singleton singleton = Singleton.Instance;
        singleton.DoSomething();
    }
}
