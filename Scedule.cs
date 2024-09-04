namespace FootballLeagueSimulation;

public class Scedule
{
    List<Team> Teams { get; set; } = [];
    List<Match> Matches { get; set; } = [];

    public static List<Match> GenerateScadule(List<Team> teams)
    {
        List<Match> newMatch = [];
        foreach (var item in teams)
        {
            foreach(var itemX in teams)
            {
                if(itemX.Name != item.Name)
                {
                    newMatch.Add(new Match(item, itemX));
                }
            }
        }
        return newMatch;
    }
}