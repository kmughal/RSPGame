namespace Task {
    public interface IRSPGame
    {
        string Play(Shapes player1Input,Shapes player2Input);
        int GetPlayer1Score();
        int GetPlayer2Score();
    }
}