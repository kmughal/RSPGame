namespace Task
{
    using System;

    public static class PlayersFactory
    {
        public static Shapes PlayAsComputer() => PlayAsHuman(new Random(Guid.NewGuid().GetHashCode()).Next(1, 3));

        public static Shapes PlayAsHuman(int playerInput) => new Player().Throw(playerInput);
    }
}