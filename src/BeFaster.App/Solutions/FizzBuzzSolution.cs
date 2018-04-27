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
            DeluxType fizzDeluxType;
            bool isFizz = IsFizz(number, out fizzDeluxType);

            DeluxType buzzDeluxType;
            bool isBuzz = IsBuzz(number, out buzzDeluxType);

            if (isFizz == false && isBuzz == false)
            {
                return number.ToString();
            }

            Func<string> getDeluxAnswer = () =>
            {
                if (fizzDeluxType == DeluxType.Fake || buzzDeluxType == DeluxType.Fake)
                {
                    return "fake deluxe";
                }

                if (fizzDeluxType == DeluxType.Normal || buzzDeluxType == DeluxType.Normal)
                {
                    return "deluxe";
                }

                return string.Empty;
            };

            return ($"{(isFizz ? "fizz " : "")}" +
                    $"{(isBuzz ? "buzz " : "")}" +
                    $"{getDeluxAnswer()}").Trim();
        }

        private static bool IsFizz(int num, out DeluxType deluxeType)
        {
            return IsMultipleOfAndIsDelux(num, 3, out deluxeType);
        }

        private static bool IsBuzz(int num, out DeluxType deluxeType)
        {
            return IsMultipleOfAndIsDelux(num, 5, out deluxeType);
        }

        private static bool IsMultipleOfAndIsDelux(int num, int multipleOf,  out DeluxType deluxeType)
        {
            deluxeType = DeluxType.None;
            bool containsDigit = ContainsDigit(num, multipleOf);
            bool multipleOfThree = num % multipleOf == 0;

            if (containsDigit && multipleOfThree)
            {
                deluxeType = num % 2 == 0 ? DeluxType.Normal : DeluxType.Fake;
            }

            return containsDigit || multipleOfThree;
        }

        //public static bool IsFakeDeluxe(int num)
        //{
        //    int targetNumber = num;
        //    if (targetNumber < 10)
        //    {
        //        return false;
        //    }

        //    int firstDigit = targetNumber % 10;
        //    targetNumber /= 10;
        //    do
        //    {
        //        int nextDigit = targetNumber % 10;
        //        if (nextDigit != firstDigit)
        //        {
        //            return false;
        //        }

        //        targetNumber /= 10;
        //    } while (targetNumber > 0);

        //    return num % 2 != 0;
        //}

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
