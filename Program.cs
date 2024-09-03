using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FootballLeagueSimulation;

public class Program
{
    static void Main(string[] args)
    {
        string Path = "FootballPlayerName.json";
        string jsonData = File.ReadAllText(Path);
        List<string>? names = JsonConvert.DeserializeObject<List<string>>(jsonData);
        List<string> teamPlayers = names!.GetRange(5, Math.Min(15, names.Count - 5));
        int i = 0;
        foreach (var name in teamPlayers)
        {
            i++;
            Console.Write($"{i}.");
            Console.WriteLine(name);
        }
    }
}
    


