using System.Linq;

namespace FootballLeagueSimulation;

public class League
{
    public string? Name { get; set; }
    public List<Team>? Teams { get; set; }

    public static League DetermineWinner(List<Match> match)
    {
        int z = 1;
        List<Team> teamFinalPoint = [];
        League teamList = new();
        foreach (var item in match)
        {
            teamList.Teams = [..match.Select(x => x.TeamA).Distinct()];
        }

        foreach (var a in teamList.Teams!)
        {
            a.Points = a.Wins * 3 + a.Draws;
        }
        
        foreach (var tFP in teamList.Teams.OrderByDescending(x => x.Points))
        {
            Console.WriteLine($"{z++}. Name: {tFP.Name}  Points: {tFP.Points}  Wins: {tFP.Wins}  Losses: {tFP.Losses}  Draws: {tFP.Draws}");
        }

        return null!;
    }

}
