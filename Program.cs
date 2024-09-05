using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace FootballLeagueSimulation;

public class Program
{
    static void Main(string[] args)
    {
        // int nt = 1;
        Random random = new();
        string dataTeam = File.ReadAllText("FootballTeam.json");
        var teams = JsonConvert.DeserializeObject<List<Teams>>(dataTeam);
        List<Team> finalTeam = [];
        foreach (var t in teams!)
        {
            var team = Team.GenerateTeam(t);
            finalTeam.Add(team);
        }

        Team displayTeams = new();
        displayTeams.DisplayTeams(finalTeam);

        List<Match> finalScedule = [.. Scedule.GenerateScadule(finalTeam).OrderBy(x => random.Next())];
        List<Match> matchResult = [];
        foreach (var x in finalScedule)
        {
            var winner = Match.PlayMatch(x);
            matchResult.Add(winner);
        }

        Console.WriteLine(finalScedule.Count);
        Console.WriteLine(matchResult.Count);

        
    }

}

public class Teams
{
    public string? Name { get; set; }
    public List<string>? Players { get; set; }
}


