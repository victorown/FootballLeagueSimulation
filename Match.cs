namespace FootballLeagueSimulation
{
    public class Match
    {
        public Team? TeamA { get; set; }
        public Team? TeamB { get; set; }
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }

        public void PlayMatch()
        {
            Random random = new();
            int scoreA = random.Next(0, 6);
            int scoreB = random.Next(0, 6);

            ScoreA = scoreA;
            ScoreB = scoreB;

            if (scoreA > scoreB)
            {
                TeamA!.Wins++;
                TeamB!.Losses++;
            }
            else if (scoreB > scoreA)
            {
                TeamA!.Losses++;
                TeamB!.Wins++;
            }
            else
            {
                TeamA!.Draws++;
                TeamB!.Draws++;
            }
        }

        public static void DisplayMatchResult(List<Match> matches)
        {
            // Header Tabel
            Console.WriteLine($"{"No.",-5} {"Team A",-20} {"vs",-5} {"Team B",-20} {"Score",-10}");
            Console.WriteLine(new string('-', 65));

            // Isi Tabel
            int matchNumber = 1;
            foreach (var item in matches)
            {
                Console.WriteLine($"{matchNumber++.ToString().PadRight(5)} {item.TeamA!.Name!.PadRight(20)} {"vs".PadRight(5)} {item.TeamB!.Name!.PadRight(20)} {($"{item.ScoreA} - {item.ScoreB}").PadRight(10)}");
            }

        }
    }
}
