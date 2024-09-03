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
        string Path = "FootballPlayerName.json";
        string jsonData = File.ReadAllText(Path);
        Random random = new();
        List<string>? names = [.. JsonConvert.DeserializeObject<List<string>>(jsonData)!.OrderBy(x => random.Next())];
        // List<int>  =
         
        int n = 0;
        Team team = new();
        foreach (var p in Enum.GetValues(typeof(EPosition)))
        {
            switch (p)
            {
                case EPosition.Forward:
                    for (int item = 0; item < 3; item++)
                    {      
                        Player palyerx = Player.GeneratePlayer(names[n], EPosition.Forward);
                        team.Players.Add(palyerx);
                        n++;
                    }
                    break;
                case EPosition.Midfielder:
                    foreach (var item in Enumerable.Range(1, 3))
                    {
                        Player playery = Player.GeneratePlayer(names[n], EPosition.Midfielder);
                        team.Players.Add(playery);
                        n++;
                    }
                    break;
                case EPosition.Defender:
                    foreach (var item in Enumerable.Range(1, 4))
                    {
                        Player playerz = Player.GeneratePlayer(names[n], EPosition.Defender);
                        team.Players.Add(playerz);
                        n++;
                    }
                    break;
                case EPosition.Goalkeeper:
                    Player playerg = Player.GeneratePlayer(names[n], EPosition.Goalkeeper);
                    team.Players.Add(playerg);
                    n++;
                    break;
            }
        }
        for (int i = 0; i < team.Players.Count; i++)
        {
            Console.WriteLine($"Player {i+1}: {team.Players[i].Name} - {team.Players[i].Position}");
        }
    }
}
    


