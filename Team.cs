namespace FootballLeagueSimulation
{
    public class Team
    {
        public string? Name { get; set; }
        public List<Player> Players { get; set; } = [];
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public static Team GenerateTeam(Teams teamx)
        {
            int n = 0;
            Team newTeam = new()
            {
                Name = teamx.Name
            };
            
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

    }

}