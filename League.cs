using System.Linq;

namespace FootballLeagueSimulation;

public class League
{
    public string? Name { get; set; }
    public List<Team> Teams { get; set; } = [];

    public void DetermineWinner(List<Match> match)
    {
       
        foreach (var item in match)
        {
            Teams = [.. match.Select(x => x.TeamA).Distinct()];
        }

        foreach (var a in Teams!)
        {
            a.Points = a.Wins * 3 + a.Draws;
        }

      
    }

    public void DisplayFinalLeaguaStandings()
    {
        // Header Tabel
        Console.WriteLine($"{"No.",-5} {"Team Name",-20} {"Points",-10} {"Wins",-10} {"Losses",-10} {"Draws",-10}");
        Console.WriteLine(new string('-', 70));

        int z = 1;

        // Isi Tabel
        foreach (var tFP in Teams!.OrderByDescending(x => x.Points))
        {
            Console.WriteLine($"{z++.ToString().PadRight(5)} {tFP.Name!.PadRight(20)} {tFP.Points.ToString()!.PadRight(10)} {tFP.Wins.ToString().PadRight(10)} {tFP.Losses.ToString().PadRight(10)} {tFP.Draws.ToString().PadRight(10)}");
        }

    }

}
