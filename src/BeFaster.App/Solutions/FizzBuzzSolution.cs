namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "fizz buzz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }

            return number.ToString();
        }
    }
}