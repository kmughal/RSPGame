
namespace Task
{
    using System;
    using System.Threading;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            PlayRSPGame();
            Read();
        }

        static void PlayRSPGame()
        {
            WriteLine(@"
                +--------------------------------------------------+
                |                                                  |
                |     Title: Waste an Hour Having Fun              |
                |                                                  |
                | As a frequent games player,                      |
                | I'd like to play rock, paper, scissors           |
                | so that I can spend an hour of my day having fun |
                |                                                  |
                | Acceptance Criteria                              |
                |  - Can I play Player vs Computer?                |
                |  - Can I play Computer vs Computer?              |
                |  - Can I play a different game each time?        |
                |                                                  |
                |                                                  |
                +--------------------------------------------------+
");
            Shapes player1Input = default(Shapes),
                 player2Input = default(Shapes);
            ForegroundColor = ConsoleColor.Red;
            WriteLine("to exist type anything accept yes or no !");
            var endFun = DateTime.Now.AddHours(1);
            var consoleInput = string.Empty;
            while (endFun.Subtract(DateTime.Now).Ticks > 0)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Player1: Do you want to play as human say yes / no ?");
                consoleInput = ReadLine();
                if (consoleInput.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    player1Input = PlayersFactory.PlayAsComputer();
                }
                else if (consoleInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Player1: Please enter any number from 1 to 3");
                    int value = int.Parse(ReadLine());
                    player1Input = PlayersFactory.PlayAsHuman(value);
                }
                else
                {
                    break;
                }
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Player2: Do you want to play as human say yes / no ?");
                consoleInput = ReadLine();
                if (consoleInput.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    player2Input = PlayersFactory.PlayAsComputer();
                }
                else if (consoleInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    WriteLine("Player2: Please enter any number from 1 to 3");
                    int value = int.Parse(ReadLine());
                    player2Input = PlayersFactory.PlayAsHuman(value);
                }
                else
                {
                    break;
                }

                var game = new RSPGame(new InMemoryRepository());
                WriteLine(game.Play(player1Input, player2Input));
                WriteLine($"Player1 Score: {game.GetPlayer1Score()} , Player2 Score: {game.GetPlayer2Score()}");
                Thread.Sleep(1000);
                WriteLine("\n\n Starting Again:\n");
            }
        }
    }



}
