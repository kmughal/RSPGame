namespace Task
{
    using System;
    using static System.Console;

    public class PlayAsHuman : IPlayer
    {
        
        public Shapes Throw()
        {
            WriteLine("Please enter a value between 1 .. 3");
            int playerInputShape;
            if (!int.TryParse(ReadLine(), out playerInputShape))
            {
                throw new ArgumentException(nameof(playerInputShape));
            }

            if (playerInputShape.IsValidShape())
            {
                Helpers.ThrowInvalidInputException("invalid input");
            }

            return (Shapes)playerInputShape;
        }
    }
}
