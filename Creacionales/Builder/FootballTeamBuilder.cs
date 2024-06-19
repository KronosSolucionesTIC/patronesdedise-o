
namespace Builder
{
    public class FootballTeamBuilder : IFootballTeamBuilder
    {
        private FootballTeam _team = new FootballTeam();

        public void SetName(string name)
        {
            _team.Name = name;
        }

        public void SetCoach(string coach)
        {
            _team.Coach = coach;
        }

        public void AddPlayer(string player)
        {
            _team.Players.Add(player);
        }

        public void SetStadium(string stadium)
        {
            _team.Stadium = stadium;
        }

        public FootballTeam Build()
        {
            return _team;
        }
    }
}
