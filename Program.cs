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
        // initialize random
        Random random = new();

        // get data from json file
        string dataTeam = File.ReadAllText("FootballTeam.json");
        var teams = JsonConvert.DeserializeObject<List<Teams>>(dataTeam);

        // generate teams
        List<Team> finalTeam = [];
        foreach (var t in teams!)
        {
            var team = Team.GenerateTeam(t);
            finalTeam.Add(team);
        }

        // display teams
        // Team displayTeams = new();
        // displayTeams.DisplayTeams(finalTeam);

        // generate scedule
        Scedule sceduleRes = new()
        {
            Matches = [.. Scedule.GenerateScadule(finalTeam).Matches.OrderBy(x => random.Next())]
        };


        // generate match result
        List<Match> matchResult = [];
        foreach (var x in sceduleRes.Matches)
        {
            var winner = Match.PlayMatch(x);
            matchResult.Add(winner);
        }
        
        League.DetermineWinner(matchResult);

        // foreach (var item in matchResult)
        // {
        //     Console.WriteLine($"Match: {item.TeamA!.Name} vs {item.TeamB!.Name}");
        //     Console.WriteLine($"Score: {item.ScoreA} - {item.ScoreB}");
        //     Console.WriteLine($"Team A: {item.TeamA!.Name} Wins: {item.TeamA!.Wins} Loses: {item.TeamA!.Losses} Draws: {item.TeamA!.Draws}");
        //     Console.WriteLine($"Team B: {item.TeamB!.Name} Wins: {item.TeamB!.Wins} Loses: {item.TeamB!.Losses} Draws: {item.TeamB!.Draws}");
        //     Console.WriteLine();
        // }
        
    }

}

public class Teams
{
    public string? Name { get; set; }
    public List<string>? Players { get; set; }
}


