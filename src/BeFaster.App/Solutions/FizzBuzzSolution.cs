namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = IsFizz(number);
            bool isBuzz = IsBuzz(number);
            bool isDeluxe = IsDeluxe(number);

            if (isFizz == false && isBuzz == false && isDeluxe == false)
            {
                return number.ToString();
            }

            return ($"{(isFizz ? "fizz " : "")}{(isBuzz ? "buzz " : "")}{(isDeluxe ? "deluxe" : "")}").Trim();
        }

        private static bool IsFizz(int num)
        {
            return num % 3 == 0 || ContainsDigit(num, 3);
        }

        private static bool IsBuzz(int num)
        {
            return num % 5 == 0 || ContainsDigit(num, 5);
        }

        public static bool IsDeluxe(int num)
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
                if (nextDigit != firstDigit)
                {
                    return false;
                }

                num /= 10;
            } while (num > 0);

            return true;
        }

        private static bool ContainsDigit(int num, int numToCheck)
        {
            return num.ToString().Contains(numToCheck.ToString());
        }
    }
}
