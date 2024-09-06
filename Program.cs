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

        Console.WriteLine("Welcome to the Football League Simulation!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Start the simulation");
        Console.WriteLine("2. Exit");
        Console.Write("Enter your choice: ");

        int pilihan = Convert.ToInt32(Console.ReadLine());
        League league = new();
        switch (pilihan)
        {
            case 1:
                Console.Write("Enter league name: ");
                league.Name = Console.ReadLine();
                Console.WriteLine($"{league.Name} started!");
                Console.WriteLine("\n1. See Teams");
                Console.WriteLine("2. See Scedule");
                Console.WriteLine("3. Start Match");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int nextStep = Convert.ToInt32(Console.ReadLine());
                // generate teams
                foreach (var t in teams!)
                {
                    var team = Team.GenerateTeam(t);
                    league.Teams!.Add(team);
                }

                // generate scedule
                Scedule sceduleRes = new();
                sceduleRes.GenerateScadule(league.Teams);

                // {
                //     // Matches = [.. Scedule.GenerateScadule(league.Teams).Matches.OrderBy(x => random.Next())]
                //     Matches = sceduleRes.GenerateScadule(league.Teams)
                // };

                switch (nextStep)
                {
                    case 1:
                        Team.DisplayTeams(league.Teams);
                        break;
                    case 2:
                        sceduleRes.DisplayScedule();
                        break;
                    case 3:
                        Console.WriteLine("Starting the match...");
                        Console.WriteLine("1. See Match Result");
                        Console.WriteLine("2. See Final Standings");
                        Console.WriteLine("3. Exiting the program...");
                        Console.Write("Enter your choice: ");
                        int nextStep2 = Convert.ToInt32(Console.ReadLine());

                        foreach (var x in sceduleRes.Matches.OrderBy(x => random.Next()))
                        {
                            x.PlayMatch();
                        }

                        switch (nextStep2)
                        {
                            case 1:
                                Match.DisplayMatchResult(sceduleRes.Matches);
                                break;
                            case 2:
                                league.DetermineWinner(sceduleRes.Matches);
                                league.DisplayFinalLeaguaStandings();
                                break;
                            case 3:
                                Console.WriteLine("Exiting the program...");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                break;
            case 2:
                Console.WriteLine("Exiting the program...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    }

}

public class Teams
{
    public string? Name { get; set; }
    public List<string>? Players { get; set; }
}


