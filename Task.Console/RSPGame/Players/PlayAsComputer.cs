namespace Task
{
    using System;
    public class PlayAsComputer : IPlayer
    {
        static object syncObject = new object();
        public Shapes Throw()
        {
            lock (syncObject)
            {
                return (Shapes)new Random(Guid.NewGuid().GetHashCode()).Next(1, 3);
            }
        }

    }
}