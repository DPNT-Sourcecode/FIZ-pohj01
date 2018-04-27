namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if (number % 15 == 0 || (ContainsDigit(number, 5) && ContainsDigit(number, 3)))
            {
                return "fizz buzz";
            }

            if (number % 5 == 0 || ContainsDigit(number, 5))
            {
                return "buzz";
            }

            if (number % 3 == 0 || ContainsDigit(number, 3))
            {
                return "fizz";
            }

            return number.ToString();
        }

        private static bool ContainsDigit(int num, int numToCheck)
        {
            return num.ToString().Contains(numToCheck.ToString());
        }
    }
}