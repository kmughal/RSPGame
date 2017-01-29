
namespace Task.RSP.Web.Controllers
{
    using System.Web.Http;
    public class RSPGameController : ApiController
    {
        private IRSPGame _rspGame;
        public RSPGameController(IRSPGame rspGame)
        {
            _rspGame = rspGame;
        }
       
        [HttpGet]
        [Route("rspgame/computer-input/")]
        public IHttpActionResult PlayAsComputer() => Ok(PlayersFactory.PlayAsComputer());

        [HttpGet]
        [Route("rspgame/two-players/{player1input}/{player2input}")]
        public IHttpActionResult TwoPlays(int player1Input,int player2Input)
        {
            string gameOutcomeMessage = _rspGame.Play((Shapes)player1Input,(Shapes)player2Input);
            return Ok(new GameResultDto { GameResultMessage = gameOutcomeMessage, Player1Score = _rspGame.GetPlayer1Score(), Player2Score = _rspGame.GetPlayer2Score() });
        }

        [HttpGet]
        [Route("rspgame/player-with-computer/{playerinput}")]
        public IHttpActionResult PlayWithComputer(int playerInput)
        {
            string gameOutcomeMessage = _rspGame.Play((Shapes)playerInput, PlayersFactory.PlayAsComputer());
            return Ok(new GameResultDto { GameResultMessage = gameOutcomeMessage, Player1Score = _rspGame.GetPlayer1Score(), Player2Score = _rspGame.GetPlayer2Score() });
        }
    }
}