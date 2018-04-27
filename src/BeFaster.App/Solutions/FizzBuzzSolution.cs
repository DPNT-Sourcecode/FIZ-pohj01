using System;
using System.Net.Configuration;

namespace BeFaster.App.Solutions
{
    public enum DeluxType
    {
        None,
        Normal,
        Fake
    }

    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizzDeluxe;
            bool isFizz = IsFizz(number, out isFizzDeluxe);

            bool isBuzzDeluxe;
            bool isBuzz = IsBuzz(number, out isBuzzDeluxe);

            bool isFakeDeluxe = IsFakeDeluxe(number);

            if (isFizz == false && isBuzz == false)
            {
                if (isFakeDeluxe)
                {
                    return "fake deluxe";
                }

                return number.ToString();
            }

            Func<string> getDeluxAnswer = () =>
            {
                if (!isFizzDeluxe && !isBuzzDeluxe && !isFakeDeluxe)
                {
                    return string.Empty;
                }

                if (isFakeDeluxe)
                {
                    return "fake deluxe";
                }

                if (isFizzDeluxe || isBuzzDeluxe)
                {
                    return "deluxe";
                }

                return "fake deluxe";
            };

            return ($"{(isFizz ? "fizz " : "")}" +
                    $"{(isBuzz ? "buzz " : "")}" +
                    $"{getDeluxAnswer()}").Trim();
        }

        private static bool IsFizz(int num, out DeluxType deluxeType)
        {
            bool containsDigit = ContainsDigit(num, 3);
            bool multipleOfThree = num % 3 == 0;

            isDeluxe = containsDigit && multipleOfThree && num > 10;
            return containsDigit || multipleOfThree;
        }

        private static bool IsBuzz(int num, out DeluxType deluxeType)
        {
            bool containsDigit = ContainsDigit(num, 5);
            bool multipleOfFive = num % 5 == 0;

            isDeluxe = containsDigit && multipleOfFive && num > 10;
            return containsDigit || multipleOfFive;
        }

        public static bool IsFakeDeluxe(int num)
        {
            int targetNumber = num;
            if (targetNumber < 10)
            {
                return false;
            }

            int firstDigit = targetNumber % 10;
            targetNumber /= 10;
            do
            {
                int nextDigit = targetNumber % 10;
                if (nextDigit != firstDigit)
                {
                    return false;
                }

                targetNumber /= 10;
            } while (targetNumber > 0);

            return num % 2 != 0;
        }

        //private static DeluxType DetermineDeluxType(int num)
        //{
        //    if (num % 2 == 0)
        //    {
        //        return DeluxType.Normal;
        //    }

        //    return DeluxType.Fake;
        //}

        private static bool ContainsDigit(int num, int numToCheck)
        {
            return num.ToString().Contains(numToCheck.ToString());
        }
    }
}
