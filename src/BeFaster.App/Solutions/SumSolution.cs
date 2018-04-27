using System;

namespace BeFaster.App.Solutions
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (isValidParameter(x) == false)
            {
                Console.WriteLine("x should be in range from 0 to 100");
                return -1;
            }

            if (isValidParameter(y) == false)
            {
                Console.WriteLine("y should be in range from 0 to 100");
                return -1;
            }

            return x + y;
        }

        private static bool isValidParameter(int parameter)
        {
            return (parameter >= 0 && parameter <= 100);
        }
    }
}