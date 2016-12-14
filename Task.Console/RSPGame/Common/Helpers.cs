namespace Task
{
    public static class Helpers {
        public static InvalidInputException ThrowInvalidInputException(string message)
        {
            return new InvalidInputException(message);
        }

        public static bool IsValidShape(this int value) {
            return value >= 1 && value <= 3;
        }
    }
}