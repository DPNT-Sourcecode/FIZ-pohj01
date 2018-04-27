using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeFaster.App.Solutions;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions
{
    [TestFixture]
    public class FizzBuzzSolutionTests
    {
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        public void FizzBuzzTest(int num)
        {
            FizzBuzzSolution.FizzBuzz(num);
        }
    }
}
