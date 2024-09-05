namespace FootballLeagueSimulation;

public class Match(Team teamA, Team teamB)
{
    public Team TeamA { get; set; } = teamA;
    public Team TeamB { get; set; } = teamB;
    public int ScoreA { get; set; }
    public int ScoreB { get; set; }

    public static Match PlayMatch(Match matches)
    {
        Random random = new();
        int winner = random.Next(1, 4);
        Team resTeamA, resTeamB;
        Match matchResult;
        if (winner == 1)
        {
            resTeamA = new Team { Name = matches.TeamA.Name, Wins = 1, Points = 2 };
            resTeamB = new Team { Name = matches.TeamB.Name, Losses = 1 };
            matchResult = new(resTeamA, resTeamB);
            return matchResult;
        }
        else if (winner == 2)
        {
            resTeamA = new Team { Name = matches.TeamA.Name, Losses = 1 };
            resTeamB = new Team { Name = matches.TeamB.Name, Wins = 1, Points = 2 };
            matchResult = new(resTeamA, resTeamB);
            return matchResult;
        }
        else
        {
            resTeamA = new Team { Name = matches.TeamA.Name, Draws = 1, Points = 1 };
            resTeamB = new Team { Name = matches.TeamB.Name, Draws = 1, Points = 1 };
            matchResult = new(resTeamA, resTeamB);
            return matchResult;
        }        
    }
}