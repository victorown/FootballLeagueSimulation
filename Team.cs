namespace FootballLeagueSimulation
{
    public class Team
    {
        public string? Name { get; set; }
        public List<Player> Players { get; set; } = [];
        public int? Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public static Team GenerateTeam(Teams teamx)
        {
            int n = 0;
            Team newTeam = new();
            {
                newTeam.Name = teamx.Name;
            }
            foreach (var p in Enum.GetValues(typeof(EPosition)))
            {
                switch (p)
                {
                    case EPosition.Forward:
                        for (int item = 0; item < 3; item++)
                        {
                            Player playerx = Player.GeneratePlayer(teamx.Players![n], EPosition.Forward);
                            newTeam.Players.Add(playerx);
                            n++;
                        }
                        break;
                    case EPosition.Midfielder:
                        foreach (var item in Enumerable.Range(1, 3))
                        {
                            Player playery = Player.GeneratePlayer(teamx.Players![n], EPosition.Midfielder);
                            newTeam.Players.Add(playery);
                            n++;
                        }
                        break;
                    case EPosition.Defender:
                        foreach (var item in Enumerable.Range(1, 4))
                        {
                            Player playerz = Player.GeneratePlayer(teamx.Players![n], EPosition.Defender);
                            newTeam.Players.Add(playerz);
                            n++;
                        }
                        break;
                    case EPosition.Goalkeeper:
                        Player playerg = Player.GeneratePlayer(teamx.Players![n], EPosition.Goalkeeper);
                        newTeam.Players.Add(playerg);
                        n++;
                        break;
                }
            }
            return newTeam;
        }

        public static void DisplayTeams(List<Team> finalTeams)
        {
            int nt = 1;
            // Set the table header with fixed column width
            string header = "| {0,-3} | {1,-20} | {2,-15} | {3,-7} | {4,-10} | {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10} | {10,-10} | {11,-10} | {12,-10} |";
            Console.WriteLine(header, "#", "Name", "Position", "Height", "Strength", "Tackle", "Stamina", "Passing", "Control", "Speed", "Acceleration", "Shot", "Handling/Reflexes");

            // // Print a separator line
            Console.WriteLine(new string('-', 148));

            foreach (var item in finalTeams)
            {
                Console.WriteLine($"{nt++}. Team: {item.Name}");
                int n = 1;
                foreach (var p in item.Players)
                {
                    // Display the player data in a table row format
                    Console.WriteLine(header,
                        n++,
                        p.Name,
                        p.Position,
                        p.Height,
                        p.Strength,
                        p.Tackle,
                        p.Stamina,
                        p.Passing,
                        p.Control,
                        p.Speed,
                        p.Acceleration,
                        p.Shot,
                        $"{p.KeeperHandling}/{p.KeeperReflexes}");
                }
                Console.WriteLine(new string('-', 148)); // Separator after each team
                Console.WriteLine();
            }
        }

    }

}