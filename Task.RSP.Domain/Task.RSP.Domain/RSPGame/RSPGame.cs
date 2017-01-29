namespace Task
{
    using static GamesConstants;   

    public class RSPGame : IRSPGame
    {
        IPlayerScoreRepository _scoreRepository;
        public RSPGame(IPlayerScoreRepository scoreRepository) {
            _scoreRepository = scoreRepository;
        }        

        public string Play(Shapes player1Input,Shapes player2Input)
        {            

            if (player1Input == player2Input)
            {
                return TIE;
            }
            else if (player1Input == Shapes.Rock && player2Input == Shapes.Scissor)
            {
                _scoreRepository.AddScoreForPlayer1();
                return PLAYER1_WINS;
                
            }
            else if (player1Input == Shapes.Paper && player2Input == Shapes.Rock)
            {
                _scoreRepository.AddScoreForPlayer1();
                return PLAYER1_WINS;
                
            }
            else if (player1Input == Shapes.Scissor && player2Input == Shapes.Paper)
            {
                _scoreRepository.AddScoreForPlayer1();
                return PLAYER1_WINS;
            }
            else
            {
                _scoreRepository.AddScoreForPlayer2();
                return PLAYER2_WINS;

            }
        }

        public int GetPlayer1Score() => _scoreRepository.GetPlayer1Score();
        public int GetPlayer2Score() => _scoreRepository.GetPlayer2Score();
    }
}
