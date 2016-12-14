namespace Task
{
    using static System.Console;
    public interface IRSPGame
    {
        void Play();
    }
    public enum Shapes
    {
        Rock = 1, Scissor = 2, Paper = 3
    }

    public class RSPGame : IRSPGame
    {
        int player1Score;
        int player2Score;

        IPlayer player1 = default(IPlayer);
        IPlayer player2 = default(IPlayer);

        public RSPGame(IPlayer Player1, IPlayer Player2)
        {
            player1 = Player1;
            player2 = Player2;
        }
        
        public void Play()
        {
            Shapes player1Input = player1.Throw(),
                   player2Input = player2.Throw();
            if (player1Input == player2Input)
            {
                WriteLine("Tie");
            }
            else if (player1Input == Shapes.Rock && player2Input == Shapes.Scissor)
            {
                WriteLine(GameMessages.PLAYER1_WINS);
                player1Score++;
            }
            else if (player1Input == Shapes.Paper && player2Input == Shapes.Rock)
            {
                WriteLine(GameMessages.PLAYER1_WINS);
                player1Score++;
            }
            else if (player1Input == Shapes.Scissor && player2Input == Shapes.Paper)
            {
                WriteLine(GameMessages.PLAYER1_WINS);
                player1Score++;
            }
            else
            {
                WriteLine(GameMessages.PLAYER2_WINS);
                player2Score++;
            }
        }

        public int GetPlayer1Score() => player1Score;
        public int GetPlayer2Score() => player2Score;

    }
}
