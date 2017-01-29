namespace Task.Tests
{
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task;
    using static GamesConstants;

    [TestClass]    
    public class RSPGameTests
    {
        
        IRSPGame rspGame;

        [TestInitialize]
        public void Initialize()
        {
            rspGame = new RSPGame(new InMemoryRepository());
            
        }

        [TestMethod]
        [TestCategory("Player 1 :")]
        public void WhenPlayer1ThrowRocksAndPlayer2ThrowsScissorThenPlayer1ShouldWin()
        {
            // arrange

            // act
            string targetMessage = rspGame.Play(Shapes.Rock, Shapes.Scissor);
            int player1Score = rspGame.GetPlayer1Score(),
                player2Score = rspGame.GetPlayer2Score();           

            // assert
            Assert.AreEqual(player1Score > player2Score, true);
            Assert.AreEqual(PLAYER1_WINS, targetMessage);
        }

        [TestMethod]
        [TestCategory("Player 1 :")]
        public void WhenPlayer1ThrowPaperAndPlayer2ThrowsRockThenPlayer1ShouldWin()
        {
            // arrange

            // act
            string targetMessage = rspGame.Play(Shapes.Paper, Shapes.Rock);
            int player1Score = rspGame.GetPlayer1Score(),
                player2Score = rspGame.GetPlayer2Score();

            // assert
            Assert.AreEqual(player1Score > player2Score, true);
            Assert.AreEqual(PLAYER1_WINS, targetMessage);            
        }

        [TestMethod]
        [TestCategory("Player 1 :")]
        public void WhenPlayer1ThrowScissorAndPlayer2ThrowsPaperThenPlayer1ShouldWin()
        {
            // arrange

            // act
            string targetMessage = rspGame.Play(Shapes.Scissor, Shapes.Paper);
            int player1Score = rspGame.GetPlayer1Score(),
                player2Score = rspGame.GetPlayer2Score();

            // assert
            Assert.AreEqual(player1Score > player2Score, true);
            Assert.AreEqual(PLAYER1_WINS, targetMessage);
        }

        [TestMethod]
        [TestCategory("Player 1 :")]
        public void WhenPlayer1AndPlayer2ThrowsSameShapesThenItShouldTie()
        {
            // arrange

            // act
            string targetMessage = rspGame.Play(Shapes.Scissor, Shapes.Scissor);            
            
            // assert
            Assert.AreEqual(TIE, targetMessage);
        }

        [TestCategory("Excpetions :")]
        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void WhenWrongInputValuesAreProvidedThenCallingPlayShouldThrowInvalidInputException()
        {
            PlayersFactory.PlayAsHuman(100);
        }

        [TestMethod]
        [TestCategory("Input : ")]
        public void WhenPlayAsComputerThenInputMustBeValid() => Assert.AreEqual(!((int)PlayersFactory.PlayAsComputer()).IsNotValidShape(), true);


    }
}
