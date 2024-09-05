namespace FootballLeagueSimulation
{
    public class Match
    {
        public Team? TeamA { get; set; }
        public Team? TeamB { get; set; }
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }

        public static Match PlayMatch(Match matches)
        {
            Random random = new();
            int scoreA = random.Next(0, 6);
            int scoreB = random.Next(0, 6);

            matches.ScoreA = scoreA;
            matches.ScoreB = scoreB;

            if (scoreA > scoreB)
            {
                matches.TeamA!.Wins ++;
                matches.TeamB!.Losses ++;
            }
            else if (scoreB > scoreA)
            {
                matches.TeamA!.Losses ++;
                matches.TeamB!.Wins ++;
            }
            else
            {
                matches.TeamA!.Draws ++;
                matches.TeamB!.Draws ++;
            }
            
            return matches;
        }
    }
}
