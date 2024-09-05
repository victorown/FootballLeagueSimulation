namespace FootballLeagueSimulation;

public class Scedule
{
    // public List<Team> Teams { get; set; } = [];
    public List<Match> Matches { get; set; } = [];

    public static Scedule GenerateScadule(List<Team> teams)
    {
        Scedule newScedule = new();
        foreach (var item in teams)
        {
            foreach(var itemX in teams)
            {
                if(itemX.Name != item.Name)
                {
                    newScedule.Matches.Add(new Match {TeamA = item, TeamB = itemX});
                }
            }
        }
        return newScedule;
    }
}