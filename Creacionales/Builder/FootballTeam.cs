
namespace Builder
{
    public class FootballTeam
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public List<string> Players { get; set; } = new List<string>();
        public string Stadium { get; set; }

        public override string ToString()
        {
            return $"Team: {Name}, Coach: {Coach}, Stadium: {Stadium}, Players: {string.Join(", ", Players)}";
        }
    }
}
