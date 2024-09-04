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

        List<Match> finalScedule = [..Scedule.GenerateScadule(finalTeam).OrderBy(x => random.Next())];
        List<Team> matchResult = [];
        foreach (var x in finalScedule)
        {
            var winner = Match.PlayMatch(x);
            matchResult.Add(winner);
        }
        
        for (int i = 0; i < finalScedule.Count; i++)
        {
            Console.WriteLine($"{finalScedule[i].TeamA.Name} vs {finalScedule[i].TeamB.Name}");
            Console.WriteLine($"Winner: {matchResult[i].Name}");
            Console.WriteLine();
        }

        // Set the table header with fixed column width
        // string header = "| {0,-3} | {1,-20} | {2,-15} | {3,-7} | {4,-10} | {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10} | {10,-10} | {11,-10} | {12,-10} |";
        // Console.WriteLine(header, "#", "Name", "Position", "Height", "Strength", "Tackle", "Stamina", "Passing", "Control", "Speed", "Acceleration", "Shot", "Handling/Reflexes");

        // // Print a separator line
        // Console.WriteLine(new string('-', 148));

        // foreach (var item in finalTeam)
        // {
        //     Console.WriteLine($"{nt++}. Team: {item.Name}");
        //     int n = 1;
        //     foreach (var p in item.Players)
        //     {
        //         // Display the player data in a table row format
        //         Console.WriteLine(header,
        //             n++,
        //             p.Name,
        //             p.Position,
        //             p.Height,
        //             p.Strength,
        //             p.Tackle,
        //             p.Stamina,
        //             p.Passing,
        //             p.Control,
        //             p.Speed,
        //             p.Acceleration,
        //             p.Shot,
        //             $"{p.KeeperHandling}/{p.KeeperReflexes}");
        //     }
        //     Console.WriteLine(new string('-', 148)); // Separator after each team
        //     Console.WriteLine();
        // }
    }

}

public class Teams
{
    public string? Name { get; set; }
    public List<string>? Players { get; set; }
}


