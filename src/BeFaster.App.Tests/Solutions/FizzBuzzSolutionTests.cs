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
        [TestCase(501, ExpectedResult = "buzz")]
        [TestCase(778, ExpectedResult = "778")]
        [TestCase(150, ExpectedResult = "fizz buzz")]
        public string FizzBuzzTest_FIZ_R2(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }
    }
}