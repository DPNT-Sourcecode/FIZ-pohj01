﻿using BeFaster.App.Solutions;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions
{
    [TestFixture]
    public class FizzBuzzSolutionTests
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "fizz fake deluxe")]
        [TestCase(5, ExpectedResult = "buzz fake deluxe")]
        [TestCase(10, ExpectedResult = "buzz")]
        [TestCase(12, ExpectedResult = "fizz")]
        [TestCase(15, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(20, ExpectedResult = "buzz")]
        [TestCase(21, ExpectedResult = "fizz")]
        [TestCase(30, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        [TestCase(45, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(135, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(237, ExpectedResult = "fizz fake deluxe")]
        [TestCase(465, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(1000, ExpectedResult = "buzz")]
        [TestCase(1400, ExpectedResult = "buzz")]
        [TestCase(1155, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(2265, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(3510, ExpectedResult = "fizz buzz deluxe")]
        public string FizzBuzzTest_NumIsMultiply(int num)
        {
            return FizzBuzzSolution.FizzBuzz(num);
        }

        //[TestCase(1, ExpectedResult = "1")]
        //[TestCase(2, ExpectedResult = "2")]
        //[TestCase(7, ExpectedResult = "7")]
        //public string FizzBuzzTest_NumIsNotMultiply(int num)
        //{
        //    return FizzBuzzSolution.FizzBuzz(num);
        //}

        //[TestCase(103, ExpectedResult = "fizz")]
        //[TestCase(153, ExpectedResult = "fizz buzz deluxe")]
        //[TestCase(501, ExpectedResult = "fizz buzz")]
        //[TestCase(778, ExpectedResult = "778")]
        //[TestCase(150, ExpectedResult = "fizz buzz deluxe")]
        //[TestCase(546, ExpectedResult = "fizz buzz")]
        //public string FizzBuzzTest_FIZ_R2(int num)
        //{
        //    return FizzBuzzSolution.FizzBuzz(num);
        //}

        //[TestCase(111, ExpectedResult = "fizz fake deluxe")]
        //[TestCase(253, ExpectedResult = "fizz buzz")]
        //[TestCase(300, ExpectedResult = "fizz buzz deluxe")]
        //[TestCase(333, ExpectedResult = "fizz fake deluxe")]
        //[TestCase(666, ExpectedResult = "fizz")]
        //[TestCase(555, ExpectedResult = "fizz buzz fake deluxe")]
        //[TestCase(5555, ExpectedResult = "buzz fake deluxe")]
        //[TestCase(1111, ExpectedResult = "fake deluxe")]
        //[TestCase(7777, ExpectedResult = "fake deluxe")]
        //[TestCase(9999, ExpectedResult = "fizz fake deluxe")]
        //public string FizzBuzzTest_FIZ_R3(int num)
        //{
        //    return FizzBuzzSolution.FizzBuzz(num);
        //}

        //[TestCase(1, ExpectedResult = false)]
        //[TestCase(10, ExpectedResult = false)]
        //[TestCase(11, ExpectedResult = true)]
        //[TestCase(55, ExpectedResult = true)]
        //[TestCase(57, ExpectedResult = false)]
        //[TestCase(60, ExpectedResult = false)]
        //[TestCase(100, ExpectedResult = false)]
        //[TestCase(111, ExpectedResult = true)]
        //[TestCase(999, ExpectedResult = true)]
        //[TestCase(979, ExpectedResult = false)]
        //[TestCase(1999, ExpectedResult = false)]
        //[TestCase(9991, ExpectedResult = false)]
        //[TestCase(9999, ExpectedResult = true)]
        //public bool FizzBuzzTest_IsDeluxe(int num)
        //{
        //    return FizzBuzzSolution.IsFakeDeluxe(num);
        //}

        //[TestCase(11, ExpectedResult = DeluxType.Fake)]
        //[TestCase(22, ExpectedResult = DeluxType.Normal)]
        //[TestCase(55, ExpectedResult = DeluxType.Fake)]
        //[TestCase(111, ExpectedResult = DeluxType.Fake)]
        //[TestCase(222, ExpectedResult = DeluxType.Normal)]
        //[TestCase(999, ExpectedResult = DeluxType.Fake)]
        //[TestCase(5555, ExpectedResult = DeluxType.Fake)]
        //[TestCase(6666, ExpectedResult = DeluxType.Normal)]
        //[TestCase(9999, ExpectedResult = DeluxType.Fake)]
        //public DeluxType FizzBuzzTest_IsDeluxe_DeluxType(int num)
        //{
        //    DeluxType? deluxType;
        //    FizzBuzzSolution.IsDeluxe(num, out deluxType);

        //    return deluxType.Value;
        //}



    }
}
