namespace FootballLeagueSimulation
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Acceleration { get; set; }
        public int Tackle { get; set; }
        public int Stamina { get; set; }
        public int Passing { get; set; }
        public int Control { get; set; }
        public int Shot { get; set; }
        public int KeeperHandling { get; set; }
        public int KeeperReflexes { get; set; }

        public static Player GeneratePlayer(string playerName, EPosition position)
        {
            Random random = new();
            return position switch
            {
                EPosition.Forward => new Player
                {
                    Name = playerName,
                    Position = "Forward",
                    Height = random.Next(173, 175),
                    Speed = random.Next(70, 90),
                    Strength = random.Next(60, 80),
                    Acceleration = random.Next(70, 90),
                    Tackle = random.Next(40, 60),
                    Stamina = random.Next(70, 90),
                    Passing = random.Next(60, 80),
                    Control = random.Next(70, 90),
                    Shot = random.Next(70, 90)
                },
                EPosition.Midfielder => new Player
                {
                    Name = playerName,
                    Position = "Midfielder",
                    Height = random.Next(175, 180),
                    Speed = random.Next(60, 90),
                    Strength = random.Next(60, 85),
                    Acceleration = random.Next(60, 90),
                    Tackle = random.Next(60, 80),
                    Stamina = random.Next(80, 90),
                    Passing = random.Next(75, 90),
                    Control = random.Next(75, 90),
                    Shot = random.Next(60, 85)
                },
                EPosition.Defender => new Player
                {
                    Name = playerName,
                    Position = "Defender",
                    Height = random.Next(180, 188),
                    Speed = random.Next(60, 80),
                    Strength = random.Next(70, 90),
                    Acceleration = random.Next(60, 80),
                    Tackle = random.Next(70, 90),
                    Stamina = random.Next(70, 90),
                    Passing = random.Next(65, 80),
                    Control = random.Next(60, 80),
                    Shot = random.Next(40, 60)
                },
                EPosition.Goalkeeper => new Player
                {
                    Name = playerName,
                    Position = "Goalkeeper",
                    Height = random.Next(185, 195),
                    Speed = random.Next(40, 60),
                    Strength = random.Next(70, 90),
                    Acceleration = random.Next(40, 60),
                    Tackle = random.Next(60, 80),
                    Stamina = random.Next(60, 80),
                    Passing = random.Next(50, 70),
                    Control = random.Next(50, 70),
                    Shot = random.Next(40, 60),
                    KeeperHandling = random.Next(70, 90),
                    KeeperReflexes = random.Next(70, 90)
                },
                _ => new Player(),
            };
        }
    }
}