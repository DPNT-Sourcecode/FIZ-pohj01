﻿using System;
using System.Net.Configuration;

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
            bool isFizzDeluxe;
            bool isFizz = IsFizz(number, out isFizzDeluxe);

            bool isBuzzDeluxe;
            bool isBuzz = IsBuzz(number, out isBuzzDeluxe);

            DeluxType? deluxType;
            IsDeluxe(number, out deluxType);

            if (isFizz == false && isBuzz == false && !deluxType.HasValue && deluxType.Value != DeluxType.Fake)
            {
                return number.ToString();
            }

            Func<string> getDeluxAnswer = () =>
            {
                if (deluxType.HasValue == false)
                {
                    return string.Empty;
                }

                return deluxType.Value == DeluxType.Normal ? "deluxe" : "fake deluxe";
            };

            return ($"{(isFizz ? "fizz " : "")}" +
                    $"{(isBuzz ? "buzz " : "")}" +
                    $"{getDeluxAnswer()}").Trim();
        }

        private static bool IsFizz(int num, out bool isDeluxe)
        {
            if (num % 3 != 0)
            {
                isDeluxe = false;
                return false;
            }

            isDeluxe = ContainsDigit(num, 3);
            return true;
        }

        private static bool IsBuzz(int num, out bool isDeluxe)
        {
            if (num % 5 != 0)
            {
                isDeluxe = false;
                return false;
            }

            isDeluxe = ContainsDigit(num, 5);
            return true;
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
