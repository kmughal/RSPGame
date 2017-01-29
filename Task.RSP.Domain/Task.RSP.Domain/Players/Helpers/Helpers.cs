namespace Task
{
    public static class HelpersFunctions {
        public static InvalidInputException ThrowInvalidInputException(string message)
        {
            throw new InvalidInputException(message);
        }
            
        public static bool IsNotValidShape(this int value) => !(value >= 1 && value <= 3);
    }
}