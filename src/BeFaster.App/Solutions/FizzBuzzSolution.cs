namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = IsFizz(number);
            bool isBuzz = IsBuzz(number);

            if (isFizz && isBuzz)
            {
                return "fizz buzz";
            }

            if (isBuzz)
            {
                return "buzz";
            }

            if (isFizz)
            {
                return "fizz";
            }

            return number.ToString();
        }

        private static bool IsFizz(int num)
        {
            return num % 3 == 0 || ContainsDigit(num, 3);
        }

        private static bool IsBuzz(int num)
        {
            return num % 5 == 0 || ContainsDigit(num, 5);
        }

        private static bool IsDeluxe(int num)
        {
            if (num < 10)
            {
                return false;
            }

            int firstDigit = num % 10;
            num /= 10;
            do
            {
                int nextDigit = num % 10;

            } while (b);
        }

        private static bool ContainsDigit(int num, int numToCheck)
        {
            return num.ToString().Contains(numToCheck.ToString());
        }
    }
}
