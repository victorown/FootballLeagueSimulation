namespace FootballLeagueSimulation
{
    public class Team
    {
        public string? Name { get; set; }
        public List<Player> Players { get; set; } = [];
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }

    // public FootballPlayer GeneratePlayers(string playerName, string position, )
    // {

    // }
}