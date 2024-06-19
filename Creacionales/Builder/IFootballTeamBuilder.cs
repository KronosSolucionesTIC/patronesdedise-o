
namespace Builder
{
    public interface IFootballTeamBuilder
    {
        void SetName(string name);
        void SetCoach(string coach);
        void AddPlayer(string player);
        void SetStadium(string stadium);
        FootballTeam Build();
    }
}
