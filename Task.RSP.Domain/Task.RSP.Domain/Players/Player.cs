namespace Task
{   
    using static GamesConstants;
    using static HelpersFunctions;

    public class Player : IPlayer
    {
        public Shapes Throw(int playerInput)
        {
            if (playerInput.IsNotValidShape())
            {
               ThrowInvalidInputException(INVALID_INPUT);
            }

            return (Shapes)playerInput;
        }
    }

}