using Builder;

public class Program
{
    public static void Main(string[] args)
    {
        IFootballTeamBuilder builder = new FootballTeamBuilder();
        FootballTeamDirector director = new FootballTeamDirector(builder);

        director.ConstructTeam();
        FootballTeam team = builder.Build();

        Console.WriteLine(team);
    }
}
