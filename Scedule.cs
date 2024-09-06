namespace FootballLeagueSimulation;

public class Scedule
{
    // public List<Team> Teams { get; set; } = [];
    public List<Match> Matches { get; set; } = [];

    public void GenerateScadule(List<Team> teams)
    {
        foreach (var item in teams)
        {
            foreach (var itemX in teams)
            {
                if (itemX.Name != item.Name)
                {
                    Matches.Add(new Match { TeamA = item, TeamB = itemX });
                }
            }
        }
    }

    public void DisplayScedule()
    {
        // Header Tabel
        Console.WriteLine($"{"No.",-5} {"Team A",-20} {"vs",-5} {"Team B",-20}");
        Console.WriteLine(new string('-', 55));

        // Isi Tabel
        int matchNumber = 1;
        foreach (var item in Matches)
        {
            Console.WriteLine($"{matchNumber++.ToString().PadRight(5)} {item.TeamA!.Name!.PadRight(20)} {"vs".PadRight(5)} {item.TeamB!.Name!.PadRight(20)}");
        }

    }
}