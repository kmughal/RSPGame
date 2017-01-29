namespace Task
{
    public class InMemoryRepository : IPlayerScoreRepository
    {
        static int player1Score = default(int);
        static int player2Score = default(int);
        public void AddScoreForPlayer1() => player1Score++;
        public void AddScoreForPlayer2() => player2Score++;
        public int GetPlayer1Score() => player1Score;
        public int GetPlayer2Score() => player2Score;
    }
}