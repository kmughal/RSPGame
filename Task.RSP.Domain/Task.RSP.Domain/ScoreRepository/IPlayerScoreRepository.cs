namespace Task
{
    public interface IPlayerScoreRepository
    {
        void AddScoreForPlayer1();
        int GetPlayer1Score();

        void AddScoreForPlayer2();
        int GetPlayer2Score();

    }
}