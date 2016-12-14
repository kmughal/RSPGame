namespace Task.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task;
    using Moq;

    [TestClass]    
    public class RSPGameTests
    {
        Mock<IPlayer> player1Mock;
        Mock<IPlayer> player2Mock;
        RSPGame game;

        [TestInitialize]
        public void Initialize()
        {
            player1Mock = new Mock<IPlayer>();
            player2Mock = new Mock<IPlayer>();
            
        }

        [TestMethod]
        [TestCategory("RSPGame")]
        public void WhenPlayer1ThrowRocksAndPlayer2ThrowsScissorThenPlayer1ShouldWin()
        {
            player1Mock.Setup(It => It.Throw()).Returns(Shapes.Rock);
            player2Mock.Setup(It => It.Throw()).Returns(Shapes.Scissor);
                    
            game = new RSPGame(player1Mock.Object,player2Mock.Object);
            game.Play();

            int player1Score = game.GetPlayer1Score(),
                player2Score = game.GetPlayer2Score();

            Assert.AreEqual(player1Score > player2Score, true);
        }

        [TestMethod]
        [TestCategory("RSPGame")]
        public void WhenPlayer1ThrowPaperAndPlayer2ThrowsRockThenPlayer1ShouldWin()
        {
            player1Mock.Setup(It => It.Throw()).Returns(Shapes.Paper);
            player2Mock.Setup(It => It.Throw()).Returns(Shapes.Rock);

            game = new RSPGame(player1Mock.Object, player2Mock.Object);
            game.Play();

            int player1Score = game.GetPlayer1Score(),
                player2Score = game.GetPlayer2Score();

            Assert.AreEqual(player1Score > player2Score, true);
        }

        [TestMethod]
        [TestCategory("RSPGame")]
        public void WhenPlayer1ThrowScissorAndPlayer2ThrowsPaperThenPlayer1ShouldWin()
        {
            player1Mock.Setup(It => It.Throw()).Returns(Shapes.Scissor);
            player2Mock.Setup(It => It.Throw()).Returns(Shapes.Paper);

            game = new RSPGame(player1Mock.Object, player2Mock.Object);
            game.Play();

            int player1Score = game.GetPlayer1Score(),
                player2Score = game.GetPlayer2Score();

            Assert.AreEqual(player1Score > player2Score, true);
        }

        [TestMethod]
        [TestCategory("RSPGame")]
        public void WhenPlayer1AndPlayer2ThrowsSameShapesThenItShouldTie()
        {
            player1Mock.Setup(It => It.Throw()).Returns(Shapes.Paper);
            player2Mock.Setup(It => It.Throw()).Returns(Shapes.Paper);

            game = new RSPGame(player1Mock.Object, player2Mock.Object);
            game.Play();

            int player1Score = game.GetPlayer1Score(),
                player2Score = game.GetPlayer2Score();

            Assert.AreEqual(player1Score == player2Score, true);
        }

    }
}
