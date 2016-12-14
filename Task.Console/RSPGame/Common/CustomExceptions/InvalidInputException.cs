namespace Task
{
    using System;
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base()
        {

        }

        public InvalidInputException(string message):base(message)
        {

        }
    }
}