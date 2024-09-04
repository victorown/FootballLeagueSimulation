namespace FootballLeagueSimulation;

public class Match(Team teamA, Team teamB)
{
    public Team TeamA { get; set; } = teamA;
    public Team TeamB { get; set; } = teamB;
    public int ScoreA { get; set; }
    public int ScoreB { get; set; }

    public static Team PlayMatch(Match matches)
    {
        Random random = new();
        int winner = random.Next(1, 3);
        if (winner == 1)
        {
            Team winner = new()
            {
                Name = matches.TeamA.Name,
                
            }
        }
        else
        {
            Team winner = new()
            {
                Name = matches.TeamA.Name,
                
            }
        }
        return null!;
    }
}