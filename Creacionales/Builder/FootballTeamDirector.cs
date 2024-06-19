
namespace Builder
{
    public class FootballTeamDirector
    {
        private readonly IFootballTeamBuilder _builder;

        public FootballTeamDirector(IFootballTeamBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructTeam()
        {
            _builder.SetName("Dream Team");
            _builder.SetCoach("Pep Guardiola");
            _builder.SetStadium("Camp Nou");
            _builder.AddPlayer("Lionel Messi");
            _builder.AddPlayer("Andres Iniesta");
            _builder.AddPlayer("Xavi Hernandez");
            _builder.AddPlayer("Gerard Pique");
        }
    }
}
