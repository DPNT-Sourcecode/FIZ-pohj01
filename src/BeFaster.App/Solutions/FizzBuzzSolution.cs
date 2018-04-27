using System;

namespace BeFaster.App.Solutions
{
    public enum DeluxType
    {
        Normal,
        Fake
    }

    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = IsFizz(number);
            bool isBuzz = IsBuzz(number);

            DeluxType? deluxType;
            bool isDeluxe = IsDeluxe(number, out deluxType);

            if (isFizz == false && isBuzz == false && isDeluxe == false)
            {
                return number.ToString();
            }

            Func<string> getDeluxAnswer = () =>
            {
                if (deluxType.HasValue == false)
                {
                    return string.Empty;
                }

                return deluxType.Value == DeluxType.Normal ? "deluxe" : "fake";
            };

            return ($"{(isFizz ? "fizz " : "")}" +
                    $"{(isBuzz ? "buzz " : "")}" +
                    $"{(isDeluxe && deluxType.Value == DeluxType.Normal ? "deluxe" : "fake")}").Trim();
        }

        private static bool IsFizz(int num)
        {
            return num % 3 == 0 || ContainsDigit(num, 3);
        }

        private static bool IsBuzz(int num)
        {
            return num % 5 == 0 || ContainsDigit(num, 5);
        }

        public static bool IsDeluxe(int num, out DeluxType? deluxType)
        {
            int targetNumber = num;
            if (targetNumber < 10)
            {
                deluxType = null;
                return false;
            }

            int firstDigit = targetNumber % 10;
            targetNumber /= 10;
            do
            {
                int nextDigit = targetNumber % 10;
                if (nextDigit != firstDigit)
                {
                    deluxType = null;
                    return false;
                }

                targetNumber /= 10;
            } while (targetNumber > 0);

            deluxType = DetermineDeluxType(num);
            return true;
        }

        private static DeluxType DetermineDeluxType(int num)
        {
            if (num % 2 == 0)
            {
                return DeluxType.Normal;
            }

            return DeluxType.Fake;
        }

        private static bool ContainsDigit(int num, int numToCheck)
        {
            return num.ToString().Contains(numToCheck.ToString());
        }
    }
}