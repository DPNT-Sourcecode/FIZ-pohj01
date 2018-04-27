using BeFaster.App.Solutions;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(-1, 5, ExpectedResult = -1)]
        public int ComputeSum_X_invalidrange_lower(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(101, 5, ExpectedResult = -1)]
        public int ComputeSum_X_invalidrange_higher(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(5, -1, ExpectedResult = -1)]
        public int ComputeSum_Y_invalidrange_lower(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(5, 101, ExpectedResult = -1)]
        public int ComputeSum_Y_invalidrange_higher(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
    }
}
