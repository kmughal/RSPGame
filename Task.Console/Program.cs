
using System;
using System.Threading;
using static System.Console;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player1, player2;
            DateTime endFun = DateTime.Now.AddHours(1);
            while (endFun.Subtract(DateTime.Now).Ticks > 0){
                WriteLine("Player1: Do you want to play as human say yes / no ?");
                if (ReadLine().Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    player1 = new PlayAsHuman();
                }
                else
                {
                    player1 = new PlayAsComputer();
                }

                WriteLine("Player1: Do you want to play as human say yes / no ?");
                if (ReadLine().Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    player2 = new PlayAsHuman();
                }
                else
                {
                    player2 = new PlayAsComputer();
                }

                var game = new RSPGame(player1, player2);
                game.Play();
                WriteLine($"Player1 Score: {game.GetPlayer1Score()} , Player2 Score: {game.GetPlayer2Score()}");
                Thread.Sleep(1000);
                WriteLine("\n\n Starting Again:\n");
            }

            Read();
        }
    }


   
  
   
   


  
}
