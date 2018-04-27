﻿using BeFaster.App.Solutions;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions
{
    [TestFixture]
    public class FizzBuzzSolutionTests
    {
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(20, ExpectedResult = "buzz")]
        [TestCase(21, ExpectedResult = "fizz")]
        [TestCase(30, ExpectedResult = "fizz buzz")]
        public string FizzBuzzTest_NumIsMultiply(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }

        [TestCase(2, ExpectedResult = "2")]
        [TestCase(7, ExpectedResult = "7")]
        public string FizzBuzzTest_NumIsNotMultiply(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }

        [TestCase(103, ExpectedResult = "fizz")]
        [TestCase(153, ExpectedResult = "fizz buzz")]
        [TestCase(501, ExpectedResult = "fizz buzz")]
        [TestCase(778, ExpectedResult = "778")]
        [TestCase(150, ExpectedResult = "fizz buzz")]
        [TestCase(546, ExpectedResult = "fizz buzz")]
        public string FizzBuzzTest_FIZ_R2(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }

        [TestCase(111, ExpectedResult = "fizz")]
        [TestCase(300, ExpectedResult = "fizz buzz")]
        [TestCase(333, ExpectedResult = "fizz")]
        [TestCase(555, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(1111, ExpectedResult = "1111")]
        [TestCase(7777, ExpectedResult = "7777")]
        public string FizzBuzzTest_FIZ_R3(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }

        [TestCase(1, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(55, true)]
        [TestCase(57, false)]
        [TestCase(60, false)]
        [TestCase(100, false)]
        [TestCase(111, true)]
        [TestCase(999, true)]
        public bool FizzBuzzTest_IsDeluxe(int num)
        {
            return FizzBuzzSolution.IsDeluxe(num);
        }
    }
}
