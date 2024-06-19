public class Program
{
    public static void Main(string[] args)
    {
        Person originalPerson = new Person
        {
            Name = "John Doe",
            Age = 30
        };

        // Clonar la instancia del prototipo
        Person clonedPerson = (Person)originalPerson.Clone();

        clonedPerson.Name = "Jane Doe";
        clonedPerson.Age = 25;

        Console.WriteLine("Original Person: " + originalPerson);
        Console.WriteLine("Cloned Person: " + clonedPerson);
    }
}
